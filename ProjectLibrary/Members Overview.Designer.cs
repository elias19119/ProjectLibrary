namespace ProjectLibrary
{
    partial class Members_Overview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members_Overview));
            this.listMembers = new System.Windows.Forms.ListView();
            this.panaddmember = new System.Windows.Forms.Panel();
            this.btnaddmem = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtnameaddmem = new System.Windows.Forms.TextBox();
            this.txtTypeaddmem = new System.Windows.Forms.TextBox();
            this.txtExpiryaddmem = new System.Windows.Forms.TextBox();
            this.txtAddressaddmem = new System.Windows.Forms.TextBox();
            this.txtDateaddmem = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtMembID = new System.Windows.Forms.TextBox();
            this.First_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemberID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Membership_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memb_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memb_Expiry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnaddpan = new System.Windows.Forms.Button();
            this.btneditpanel = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.paneditmemb = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.txtexpiryeditmemb = new System.Windows.Forms.TextBox();
            this.btneditmemb = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtMemb = new System.Windows.Forms.TextBox();
            this.txtdateeditmemb = new System.Windows.Forms.TextBox();
            this.txtaddreeditmemb = new System.Windows.Forms.TextBox();
            this.txtTypeeditmemb = new System.Windows.Forms.TextBox();
            this.txtnameeditmemb = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panaddmember.SuspendLayout();
            this.paneditmemb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // listMembers
            // 
            this.listMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MemberID,
            this.First_Name,
            this.Address,
            this.Membership_Type,
            this.Memb_Date,
            this.Memb_Expiry});
            this.listMembers.HideSelection = false;
            this.listMembers.Location = new System.Drawing.Point(11, 106);
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(453, 313);
            this.listMembers.TabIndex = 0;
            this.listMembers.UseCompatibleStateImageBehavior = false;
            this.listMembers.View = System.Windows.Forms.View.Details;
            // 
            // panaddmember
            // 
            this.panaddmember.BackColor = System.Drawing.Color.DodgerBlue;
            this.panaddmember.Controls.Add(this.label31);
            this.panaddmember.Controls.Add(this.txtMembID);
            this.panaddmember.Controls.Add(this.btnaddmem);
            this.panaddmember.Controls.Add(this.label37);
            this.panaddmember.Controls.Add(this.label38);
            this.panaddmember.Controls.Add(this.label39);
            this.panaddmember.Controls.Add(this.label41);
            this.panaddmember.Controls.Add(this.label40);
            this.panaddmember.Controls.Add(this.txtnameaddmem);
            this.panaddmember.Controls.Add(this.txtTypeaddmem);
            this.panaddmember.Controls.Add(this.txtExpiryaddmem);
            this.panaddmember.Controls.Add(this.txtAddressaddmem);
            this.panaddmember.Controls.Add(this.txtDateaddmem);
            this.panaddmember.Location = new System.Drawing.Point(470, 106);
            this.panaddmember.Name = "panaddmember";
            this.panaddmember.Size = new System.Drawing.Size(317, 313);
            this.panaddmember.TabIndex = 1;
            // 
            // btnaddmem
            // 
            this.btnaddmem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnaddmem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddmem.Location = new System.Drawing.Point(113, 255);
            this.btnaddmem.Name = "btnaddmem";
            this.btnaddmem.Size = new System.Drawing.Size(92, 45);
            this.btnaddmem.TabIndex = 55;
            this.btnaddmem.Text = "Add";
            this.btnaddmem.UseVisualStyleBackColor = false;
            this.btnaddmem.Click += new System.EventHandler(this.btnaddmem_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 120);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(51, 13);
            this.label37.TabIndex = 54;
            this.label37.Text = "Address :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(184, 120);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(71, 13);
            this.label38.TabIndex = 53;
            this.label38.Text = "Memb_Date :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(18, 67);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(97, 13);
            this.label39.TabIndex = 52;
            this.label39.Text = "Membership Type :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(18, 13);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(66, 13);
            this.label41.TabIndex = 50;
            this.label41.Text = "First Name : ";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(184, 64);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(76, 13);
            this.label40.TabIndex = 51;
            this.label40.Text = "Memb_Expiry :";
            // 
            // txtnameaddmem
            // 
            this.txtnameaddmem.Location = new System.Drawing.Point(18, 32);
            this.txtnameaddmem.Name = "txtnameaddmem";
            this.txtnameaddmem.Size = new System.Drawing.Size(100, 20);
            this.txtnameaddmem.TabIndex = 45;
            // 
            // txtTypeaddmem
            // 
            this.txtTypeaddmem.Location = new System.Drawing.Point(18, 83);
            this.txtTypeaddmem.Name = "txtTypeaddmem";
            this.txtTypeaddmem.Size = new System.Drawing.Size(100, 20);
            this.txtTypeaddmem.TabIndex = 46;
            // 
            // txtExpiryaddmem
            // 
            this.txtExpiryaddmem.Location = new System.Drawing.Point(187, 83);
            this.txtExpiryaddmem.Name = "txtExpiryaddmem";
            this.txtExpiryaddmem.Size = new System.Drawing.Size(100, 20);
            this.txtExpiryaddmem.TabIndex = 49;
            // 
            // txtAddressaddmem
            // 
            this.txtAddressaddmem.Location = new System.Drawing.Point(18, 136);
            this.txtAddressaddmem.Name = "txtAddressaddmem";
            this.txtAddressaddmem.Size = new System.Drawing.Size(100, 20);
            this.txtAddressaddmem.TabIndex = 47;
            // 
            // txtDateaddmem
            // 
            this.txtDateaddmem.Location = new System.Drawing.Point(187, 136);
            this.txtDateaddmem.Name = "txtDateaddmem";
            this.txtDateaddmem.Size = new System.Drawing.Size(100, 20);
            this.txtDateaddmem.TabIndex = 48;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(184, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "MemberID :";
            // 
            // txtMembID
            // 
            this.txtMembID.Location = new System.Drawing.Point(187, 32);
            this.txtMembID.Name = "txtMembID";
            this.txtMembID.Size = new System.Drawing.Size(100, 20);
            this.txtMembID.TabIndex = 56;
            // 
            // First_Name
            // 
            this.First_Name.Text = "First_Name";
            this.First_Name.Width = 66;
            // 
            // MemberID
            // 
            this.MemberID.Text = "MemberID";
            this.MemberID.Width = 63;
            // 
            // Membership_Type
            // 
            this.Membership_Type.DisplayIndex = 2;
            this.Membership_Type.Text = "Membership_Type";
            this.Membership_Type.Width = 100;
            // 
            // Address
            // 
            this.Address.DisplayIndex = 3;
            this.Address.Text = "Address";
            this.Address.Width = 53;
            // 
            // Memb_Date
            // 
            this.Memb_Date.Text = "Memb_Date";
            this.Memb_Date.Width = 75;
            // 
            // Memb_Expiry
            // 
            this.Memb_Expiry.Text = "Memb_Expiry";
            this.Memb_Expiry.Width = 83;
            // 
            // btnaddpan
            // 
            this.btnaddpan.BackColor = System.Drawing.Color.PowderBlue;
            this.btnaddpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpan.Location = new System.Drawing.Point(12, 446);
            this.btnaddpan.Name = "btnaddpan";
            this.btnaddpan.Size = new System.Drawing.Size(92, 45);
            this.btnaddpan.TabIndex = 58;
            this.btnaddpan.Text = "Add";
            this.btnaddpan.UseVisualStyleBackColor = false;
            this.btnaddpan.Click += new System.EventHandler(this.btnaddpan_Click);
            // 
            // btneditpanel
            // 
            this.btneditpanel.BackColor = System.Drawing.Color.PowderBlue;
            this.btneditpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditpanel.Location = new System.Drawing.Point(696, 446);
            this.btneditpanel.Name = "btneditpanel";
            this.btneditpanel.Size = new System.Drawing.Size(92, 45);
            this.btneditpanel.TabIndex = 59;
            this.btneditpanel.Text = "Edit";
            this.btneditpanel.UseVisualStyleBackColor = false;
            this.btneditpanel.Click += new System.EventHandler(this.btneditpanel_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.PowderBlue;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(11, 69);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(92, 31);
            this.btnback.TabIndex = 60;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // paneditmemb
            // 
            this.paneditmemb.BackColor = System.Drawing.Color.DodgerBlue;
            this.paneditmemb.Controls.Add(this.label33);
            this.paneditmemb.Controls.Add(this.txtexpiryeditmemb);
            this.paneditmemb.Controls.Add(this.btneditmemb);
            this.paneditmemb.Controls.Add(this.label28);
            this.paneditmemb.Controls.Add(this.label29);
            this.paneditmemb.Controls.Add(this.label30);
            this.paneditmemb.Controls.Add(this.label1);
            this.paneditmemb.Controls.Add(this.label32);
            this.paneditmemb.Controls.Add(this.txtMemb);
            this.paneditmemb.Controls.Add(this.txtdateeditmemb);
            this.paneditmemb.Controls.Add(this.txtaddreeditmemb);
            this.paneditmemb.Controls.Add(this.txtTypeeditmemb);
            this.paneditmemb.Controls.Add(this.txtnameeditmemb);
            this.paneditmemb.Location = new System.Drawing.Point(470, 109);
            this.paneditmemb.Name = "paneditmemb";
            this.paneditmemb.Size = new System.Drawing.Size(317, 313);
            this.paneditmemb.TabIndex = 58;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(184, 142);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "Memb_Expiry :";
            // 
            // txtexpiryeditmemb
            // 
            this.txtexpiryeditmemb.Location = new System.Drawing.Point(187, 158);
            this.txtexpiryeditmemb.Name = "txtexpiryeditmemb";
            this.txtexpiryeditmemb.Size = new System.Drawing.Size(100, 20);
            this.txtexpiryeditmemb.TabIndex = 45;
            // 
            // btneditmemb
            // 
            this.btneditmemb.BackColor = System.Drawing.Color.PowderBlue;
            this.btneditmemb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditmemb.Location = new System.Drawing.Point(113, 255);
            this.btneditmemb.Name = "btneditmemb";
            this.btneditmemb.Size = new System.Drawing.Size(92, 45);
            this.btneditmemb.TabIndex = 44;
            this.btneditmemb.Text = "Edit";
            this.btneditmemb.UseVisualStyleBackColor = false;
            this.btneditmemb.Click += new System.EventHandler(this.btneditmemb_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 43;
            this.label28.Text = "Address :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(184, 89);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 13);
            this.label29.TabIndex = 42;
            this.label29.Text = "Memb_Date :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(28, 89);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 13);
            this.label30.TabIndex = 41;
            this.label30.Text = "Membership Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "MemberID :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(28, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 13);
            this.label32.TabIndex = 39;
            this.label32.Text = "First Name : ";
            // 
            // txtMemb
            // 
            this.txtMemb.Location = new System.Drawing.Point(187, 54);
            this.txtMemb.Name = "txtMemb";
            this.txtMemb.Size = new System.Drawing.Size(100, 20);
            this.txtMemb.TabIndex = 38;
            // 
            // txtdateeditmemb
            // 
            this.txtdateeditmemb.Location = new System.Drawing.Point(187, 105);
            this.txtdateeditmemb.Name = "txtdateeditmemb";
            this.txtdateeditmemb.Size = new System.Drawing.Size(100, 20);
            this.txtdateeditmemb.TabIndex = 37;
            // 
            // txtaddreeditmemb
            // 
            this.txtaddreeditmemb.Location = new System.Drawing.Point(28, 158);
            this.txtaddreeditmemb.Name = "txtaddreeditmemb";
            this.txtaddreeditmemb.Size = new System.Drawing.Size(100, 20);
            this.txtaddreeditmemb.TabIndex = 36;
            // 
            // txtTypeeditmemb
            // 
            this.txtTypeeditmemb.Location = new System.Drawing.Point(28, 105);
            this.txtTypeeditmemb.Name = "txtTypeeditmemb";
            this.txtTypeeditmemb.Size = new System.Drawing.Size(100, 20);
            this.txtTypeeditmemb.TabIndex = 35;
            // 
            // txtnameeditmemb
            // 
            this.txtnameeditmemb.Location = new System.Drawing.Point(28, 54);
            this.txtnameeditmemb.Name = "txtnameeditmemb";
            this.txtnameeditmemb.Size = new System.Drawing.Size(100, 20);
            this.txtnameeditmemb.TabIndex = 34;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(300, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(225, 97);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            // 
            // Members_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.paneditmemb);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btneditpanel);
            this.Controls.Add(this.btnaddpan);
            this.Controls.Add(this.panaddmember);
            this.Controls.Add(this.listMembers);
            this.Name = "Members_Overview";
            this.Text = "Members_Overview";
            this.Load += new System.EventHandler(this.Members_Overview_Load);
            this.panaddmember.ResumeLayout(false);
            this.panaddmember.PerformLayout();
            this.paneditmemb.ResumeLayout(false);
            this.paneditmemb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMembers;
        private System.Windows.Forms.Panel panaddmember;
        private System.Windows.Forms.Button btnaddmem;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtnameaddmem;
        private System.Windows.Forms.TextBox txtTypeaddmem;
        private System.Windows.Forms.TextBox txtExpiryaddmem;
        private System.Windows.Forms.TextBox txtAddressaddmem;
        private System.Windows.Forms.TextBox txtDateaddmem;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtMembID;
        private System.Windows.Forms.ColumnHeader MemberID;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Membership_Type;
        private System.Windows.Forms.ColumnHeader Memb_Date;
        private System.Windows.Forms.ColumnHeader Memb_Expiry;
        private System.Windows.Forms.Button btnaddpan;
        private System.Windows.Forms.Button btneditpanel;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel paneditmemb;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtexpiryeditmemb;
        private System.Windows.Forms.Button btneditmemb;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtMemb;
        private System.Windows.Forms.TextBox txtdateeditmemb;
        private System.Windows.Forms.TextBox txtaddreeditmemb;
        private System.Windows.Forms.TextBox txtTypeeditmemb;
        private System.Windows.Forms.TextBox txtnameeditmemb;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}