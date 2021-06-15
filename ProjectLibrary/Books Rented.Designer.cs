namespace ProjectLibrary
{
    partial class Books_Rented
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_Rented));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.listbooksrented = new System.Windows.Forms.ListView();
            this.Book_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Days_Rented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnback = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(318, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(225, 97);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // listbooksrented
            // 
            this.listbooksrented.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listbooksrented.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Book_ID,
            this.Publisher_ID,
            this.Author,
            this.Title,
            this.Days_Rented,
            this.Category,
            this.Price,
            this.Available});
            this.listbooksrented.FullRowSelect = true;
            this.listbooksrented.GridLines = true;
            this.listbooksrented.HideSelection = false;
            this.listbooksrented.Location = new System.Drawing.Point(159, 129);
            this.listbooksrented.Name = "listbooksrented";
            this.listbooksrented.Size = new System.Drawing.Size(536, 256);
            this.listbooksrented.TabIndex = 63;
            this.listbooksrented.UseCompatibleStateImageBehavior = false;
            this.listbooksrented.View = System.Windows.Forms.View.Details;
            this.listbooksrented.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listbooksrented_MouseClick);
            // 
            // Book_ID
            // 
            this.Book_ID.Text = "Book_ID";
            // 
            // Publisher_ID
            // 
            this.Publisher_ID.Text = "Publisher_ID";
            this.Publisher_ID.Width = 85;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Days_Rented
            // 
            this.Days_Rented.Text = "Days_Rented";
            this.Days_Rented.Width = 87;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Available
            // 
            this.Available.Text = "Available";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.PowderBlue;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(95, 38);
            this.btnback.TabIndex = 64;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(390, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 38);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Books_Rented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.listbooksrented);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Books_Rented";
            this.Text = "Books_Rented";
            this.Load += new System.EventHandler(this.Books_Rented_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListView listbooksrented;
        private System.Windows.Forms.ColumnHeader Book_ID;
        private System.Windows.Forms.ColumnHeader Publisher_ID;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Days_Rented;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.Button btnUpdate;
    }
}