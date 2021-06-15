using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModel;

namespace LibraryLogic
{
    public class MemberServices
    {
        MemberDao memberdao = new MemberDao();
        public List<Member> GetAllMembers()
        {
            //try
            //{
                return memberdao.GetAllMembers();
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
        }
        public Member GetMemberForID(int memberid)
        {
            return memberdao.GetMemberForID(memberid);
        }
        public void InsertMember(Member member)
        {
            memberdao.InsertMember(member);
        }
        public void EditMember(Member member)
        {
            memberdao.EditMember(member);
        }
        public int GetNumberofMembers()
        {
            try
            {
                return memberdao.GetNumberofMembers();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
