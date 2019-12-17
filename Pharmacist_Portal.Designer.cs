namespace Project_database
{
    partial class Pharmacist_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist_Portal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHospName = new System.Windows.Forms.Label();
            this.buttonExitDoc = new System.Windows.Forms.Button();
            this.buttonMinDoc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPharmOrder = new System.Windows.Forms.Button();
            this.buttonPharmIssue = new System.Windows.Forms.Button();
            this.buttonPharmAdd = new System.Windows.Forms.Button();
            this.buttonPharmHome = new System.Windows.Forms.Button();
            this.userControlPharmOrder1 = new Project_database.UserControlPharmOrder();
            this.userControlPharmIssue1 = new Project_database.UserControlPharmIssue();
            this.userControlPharmAdd1 = new Project_database.UserControlPharmAdd();
            this.userControlPharmHome1 = new Project_database.UserControlPharmHome();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelHospName);
            this.panel2.Controls.Add(this.buttonExitDoc);
            this.panel2.Controls.Add(this.buttonMinDoc);
            this.panel2.Location = new System.Drawing.Point(206, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 124);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "PHARMACIST PORTAL";
            // 
            // labelHospName
            // 
            this.labelHospName.AutoSize = true;
            this.labelHospName.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHospName.ForeColor = System.Drawing.Color.White;
            this.labelHospName.Location = new System.Drawing.Point(16, 35);
            this.labelHospName.Name = "labelHospName";
            this.labelHospName.Size = new System.Drawing.Size(489, 58);
            this.labelHospName.TabIndex = 6;
            this.labelHospName.Text = "DIAMOND HOSPITAL";
            // 
            // buttonExitDoc
            // 
            this.buttonExitDoc.BackColor = System.Drawing.Color.Black;
            this.buttonExitDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExitDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonExitDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonExitDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitDoc.ForeColor = System.Drawing.Color.White;
            this.buttonExitDoc.Location = new System.Drawing.Point(660, 16);
            this.buttonExitDoc.Name = "buttonExitDoc";
            this.buttonExitDoc.Size = new System.Drawing.Size(53, 30);
            this.buttonExitDoc.TabIndex = 2;
            this.buttonExitDoc.Text = "X";
            this.buttonExitDoc.UseVisualStyleBackColor = false;
            this.buttonExitDoc.Click += new System.EventHandler(this.buttonExitDoc_Click);
            // 
            // buttonMinDoc
            // 
            this.buttonMinDoc.BackColor = System.Drawing.Color.Black;
            this.buttonMinDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMinDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonMinDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonMinDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinDoc.ForeColor = System.Drawing.Color.White;
            this.buttonMinDoc.Location = new System.Drawing.Point(601, 16);
            this.buttonMinDoc.Name = "buttonMinDoc";
            this.buttonMinDoc.Size = new System.Drawing.Size(53, 30);
            this.buttonMinDoc.TabIndex = 3;
            this.buttonMinDoc.Text = "-";
            this.buttonMinDoc.UseVisualStyleBackColor = false;
            this.buttonMinDoc.Click += new System.EventHandler(this.buttonMinDoc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonPharmOrder);
            this.panel1.Controls.Add(this.buttonPharmIssue);
            this.panel1.Controls.Add(this.buttonPharmAdd);
            this.panel1.Controls.Add(this.buttonPharmHome);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 633);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPharmOrder
            // 
            this.buttonPharmOrder.BackColor = System.Drawing.Color.Black;
            this.buttonPharmOrder.FlatAppearance.BorderSize = 0;
            this.buttonPharmOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmOrder.ForeColor = System.Drawing.Color.White;
            this.buttonPharmOrder.Location = new System.Drawing.Point(6, 381);
            this.buttonPharmOrder.Name = "buttonPharmOrder";
            this.buttonPharmOrder.Size = new System.Drawing.Size(189, 49);
            this.buttonPharmOrder.TabIndex = 6;
            this.buttonPharmOrder.Text = "Order";
            this.buttonPharmOrder.UseVisualStyleBackColor = false;
            this.buttonPharmOrder.Click += new System.EventHandler(this.buttonPharmOrder_Click);
            // 
            // buttonPharmIssue
            // 
            this.buttonPharmIssue.BackColor = System.Drawing.Color.Black;
            this.buttonPharmIssue.FlatAppearance.BorderSize = 0;
            this.buttonPharmIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmIssue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmIssue.ForeColor = System.Drawing.Color.White;
            this.buttonPharmIssue.Location = new System.Drawing.Point(6, 307);
            this.buttonPharmIssue.Name = "buttonPharmIssue";
            this.buttonPharmIssue.Size = new System.Drawing.Size(189, 49);
            this.buttonPharmIssue.TabIndex = 6;
            this.buttonPharmIssue.Text = "Issue";
            this.buttonPharmIssue.UseVisualStyleBackColor = false;
            this.buttonPharmIssue.Click += new System.EventHandler(this.buttonPharmIssue_Click);
            // 
            // buttonPharmAdd
            // 
            this.buttonPharmAdd.BackColor = System.Drawing.Color.Black;
            this.buttonPharmAdd.FlatAppearance.BorderSize = 0;
            this.buttonPharmAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmAdd.ForeColor = System.Drawing.Color.White;
            this.buttonPharmAdd.Location = new System.Drawing.Point(6, 233);
            this.buttonPharmAdd.Name = "buttonPharmAdd";
            this.buttonPharmAdd.Size = new System.Drawing.Size(189, 49);
            this.buttonPharmAdd.TabIndex = 6;
            this.buttonPharmAdd.Text = "Add";
            this.buttonPharmAdd.UseVisualStyleBackColor = false;
            this.buttonPharmAdd.Click += new System.EventHandler(this.buttonPharmAdd_Click);
            // 
            // buttonPharmHome
            // 
            this.buttonPharmHome.BackColor = System.Drawing.Color.Black;
            this.buttonPharmHome.FlatAppearance.BorderSize = 0;
            this.buttonPharmHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmHome.ForeColor = System.Drawing.Color.White;
            this.buttonPharmHome.Location = new System.Drawing.Point(6, 159);
            this.buttonPharmHome.Name = "buttonPharmHome";
            this.buttonPharmHome.Size = new System.Drawing.Size(189, 49);
            this.buttonPharmHome.TabIndex = 6;
            this.buttonPharmHome.Text = "Home";
            this.buttonPharmHome.UseVisualStyleBackColor = false;
            this.buttonPharmHome.Click += new System.EventHandler(this.buttonPharmHome_Click);
            // 
            // userControlPharmOrder1
            // 
            this.userControlPharmOrder1.BackColor = System.Drawing.Color.Black;
            this.userControlPharmOrder1.Location = new System.Drawing.Point(202, 132);
            this.userControlPharmOrder1.Name = "userControlPharmOrder1";
            this.userControlPharmOrder1.Size = new System.Drawing.Size(733, 503);
            this.userControlPharmOrder1.TabIndex = 14;
            // 
            // userControlPharmIssue1
            // 
            this.userControlPharmIssue1.BackColor = System.Drawing.Color.Black;
            this.userControlPharmIssue1.Location = new System.Drawing.Point(206, 143);
            this.userControlPharmIssue1.Name = "userControlPharmIssue1";
            this.userControlPharmIssue1.Size = new System.Drawing.Size(729, 492);
            this.userControlPharmIssue1.TabIndex = 13;
            // 
            // userControlPharmAdd1
            // 
            this.userControlPharmAdd1.BackColor = System.Drawing.Color.Black;
            this.userControlPharmAdd1.Location = new System.Drawing.Point(202, 132);
            this.userControlPharmAdd1.Name = "userControlPharmAdd1";
            this.userControlPharmAdd1.Size = new System.Drawing.Size(729, 492);
            this.userControlPharmAdd1.TabIndex = 12;
            // 
            // userControlPharmHome1
            // 
            this.userControlPharmHome1.BackColor = System.Drawing.Color.Black;
            this.userControlPharmHome1.Location = new System.Drawing.Point(206, 132);
            this.userControlPharmHome1.Name = "userControlPharmHome1";
            this.userControlPharmHome1.Size = new System.Drawing.Size(725, 492);
            this.userControlPharmHome1.TabIndex = 11;
            // 
            // Pharmacist_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 636);
            this.Controls.Add(this.userControlPharmOrder1);
            this.Controls.Add(this.userControlPharmIssue1);
            this.Controls.Add(this.userControlPharmAdd1);
            this.Controls.Add(this.userControlPharmHome1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist_Portal";
            this.Load += new System.EventHandler(this.Pharmacist_Portal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHospName;
        private System.Windows.Forms.Button buttonExitDoc;
        private System.Windows.Forms.Button buttonMinDoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPharmOrder;
        private System.Windows.Forms.Button buttonPharmIssue;
        private System.Windows.Forms.Button buttonPharmAdd;
        private System.Windows.Forms.Button buttonPharmHome;
        private UserControlPharmHome userControlPharmHome1;
        private UserControlPharmAdd userControlPharmAdd1;
        private UserControlPharmIssue userControlPharmIssue1;
        private UserControlPharmOrder userControlPharmOrder1;
    }
}