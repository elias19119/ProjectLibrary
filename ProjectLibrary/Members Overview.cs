using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogic;
using LibraryModel;

namespace ProjectLibrary
{
    public partial class Members_Overview : Form
    {
        Form passedform;
        MemberServices memberServices = new MemberServices();
        public Members_Overview(Form form)
        {
            this.passedform = form;
            InitializeComponent();
        }

        private void Members_Overview_Load(object sender, EventArgs e)
        {
            panaddmember.Visible = false;
            paneditmemb.Visible = false;
            DisplayMembers();
        }
        private void btnaddmem_Click(object sender, EventArgs e)
        {
           
            Member member = new Member()
            {
                MembID = Convert.ToInt32(txtMembID.Text),
                First_Name = txtnameaddmem.Text,
                Address = txtAddressaddmem.Text,
                Memb_Type = txtTypeaddmem.Text,
                Memb_Date = Convert.ToDateTime(txtDateaddmem.Text.ToString()).Date,
                Expiry_Date = Convert.ToDateTime(txtExpiryaddmem.Text.ToString()).Date,
            };

            string message = $"Are you sure you want to add {member.First_Name}";
            string header = $"Adding a Member";
            MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                memberServices.InsertMember(member);
                MessageBox.Show("Member is added!");
            }
            DisplayMembers();



        }

        private void btnaddpan_Click(object sender, EventArgs e)
        {
            panaddmember.Visible = true;
            paneditmemb.Visible = false;
        }

        private void btneditpanel_Click(object sender, EventArgs e)
        {
            panaddmember.Visible = false;
            paneditmemb.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            passedform.Show();
            this.Close();
        }
        private void DisplayMembers() 
        {
            List<Member> members = memberServices.GetAllMembers();


            listMembers.Items.Clear();

            foreach (Member member in members)
            {
                ListViewItem list = new ListViewItem(member.MembID.ToString());
                list.SubItems.Add(member.First_Name);
                list.SubItems.Add(member.Address);
                list.SubItems.Add(member.Memb_Type);
                list.SubItems.Add(member.Memb_Date.ToString());
                list.SubItems.Add(member.Expiry_Date.ToString());
                list.Tag = member;
                listMembers.Items.Add(list);

            }
        }

        private void btneditmemb_Click(object sender, EventArgs e)
        {

            Member member = new Member()
            {
                MembID = Convert.ToInt32(txtMemb.Text),
                First_Name = txtnameeditmemb.Text,
                Address = txtaddreeditmemb.Text,
                Memb_Type = txtTypeeditmemb.Text,
                Memb_Date = Convert.ToDateTime(txtdateeditmemb.Text.ToString()).Date,
                Expiry_Date = Convert.ToDateTime(txtexpiryeditmemb.Text.ToString()).Date,
            };

            string message = $"Are you sure you want to Edit {member.First_Name}";
            string header = $"Adding a Member";
            MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                memberServices.EditMember(member);
                MessageBox.Show("Member is added!");
            }
            DisplayMembers();
        }
    }
}
