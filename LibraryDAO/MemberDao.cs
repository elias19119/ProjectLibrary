using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Configuration;
using LibraryModel;

namespace LibraryDAL
{
    public class MemberDao : Base
    {
        public List<Member> GetAllMembers()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Memb_ID,First_Name,Memb_Address,Memb_Typr,Memb_Date,Memb_Expiry FROM Member ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Member> members = new List<Member>();
            while (reader.Read())
            {
                Member member = ReadMember(reader);
                members.Add(member);
            }
            reader.Close();
            conn.Close();
            return members;
        }
        public Member ReadMember(SqlDataReader reader)
        {

            Member member = new Member()
            {
                MembID = (int)reader["Memb_ID"],
                First_Name = (string)reader["First_Name"],
                Address =(string)reader["Memb_Address"],
                Memb_Type = (string)reader["Memb_Typr"],
                Memb_Date = (DateTime)reader["Memb_Date"],
                Expiry_Date = (DateTime)reader["Memb_Expiry"],
            };
            return member;
        }
        public Member GetMemberForID(int memberid)
        {
            SqlCommand cmd = new SqlCommand("select First_Name, Memb_Address, Memb_Typr,Memb_Date,Memb_Expiry from Member where Memb_ID = @memberid", conn);
            cmd.Parameters.AddWithValue("@memberid", memberid);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Member member;
            if (reader.Read())
            {
                member = ReadMember(reader);
            }
            else
            {
                member = null;
            }
            reader.Close();
            conn.Close();
            return member;
        }
        public void InsertMember(Member member)
        {
            string query = $"insert into Member(Memb_ID,First_Name, Memb_Address, Memb_Typr,Memb_Date,Memb_Expiry) " +
                $"values('{member.MembID}','{member.First_Name}', '{member.Address}', '{member.Memb_Type}','{member.Memb_Date.Date}','{member.Expiry_Date.Date}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void EditMember(Member member)
        {
            string query = $"update Member Set First_Name = '{member.First_Name}', Memb_Address = '{member.Address}'," +
               $"Memb_Typr = '{member.Memb_Type}', Memb_Date = '{member.Memb_Date.Date}', Memb_Expiry = '{member.Expiry_Date.Date}', WHERE Memb_ID = {member.MembID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public int GetNumberofMembers()
        {
            int numberofmembers = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) AS count  FROM Member", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                numberofmembers = (int)reader["count"];
            }
            conn.Close();
            return numberofmembers;
        }
    }
}
