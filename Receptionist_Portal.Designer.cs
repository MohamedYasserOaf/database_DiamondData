namespace Project_database
{
    partial class Receptionist_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_Portal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHospName = new System.Windows.Forms.Label();
            this.buttonExitDoc = new System.Windows.Forms.Button();
            this.buttonMinDoc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRecepPayment = new System.Windows.Forms.Button();
            this.buttonRecepPatient = new System.Windows.Forms.Button();
            this.buttonRecepReserve = new System.Windows.Forms.Button();
            this.buttonRecepHome = new System.Windows.Forms.Button();
            this.userControlRecepReserve1 = new Project_database.UserControlRecepReserve();
            this.userControlRecepPayment1 = new Project_database.UserControlRecepPayment();
            this.userControlRecepPatients1 = new Project_database.UserControlRecepPatients();
            this.userControlRecepHome1 = new Project_database.UserControlRecepHome();
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
            this.panel2.Location = new System.Drawing.Point(207, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 124);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "RECEPTIONIST PORTAL";
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
            this.panel1.Controls.Add(this.buttonRecepPayment);
            this.panel1.Controls.Add(this.buttonRecepPatient);
            this.panel1.Controls.Add(this.buttonRecepReserve);
            this.panel1.Controls.Add(this.buttonRecepHome);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 633);
            this.panel1.TabIndex = 9;
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
            // buttonRecepPayment
            // 
            this.buttonRecepPayment.BackColor = System.Drawing.Color.Black;
            this.buttonRecepPayment.FlatAppearance.BorderSize = 0;
            this.buttonRecepPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonRecepPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecepPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecepPayment.ForeColor = System.Drawing.Color.White;
            this.buttonRecepPayment.Location = new System.Drawing.Point(6, 381);
            this.buttonRecepPayment.Name = "buttonRecepPayment";
            this.buttonRecepPayment.Size = new System.Drawing.Size(189, 49);
            this.buttonRecepPayment.TabIndex = 6;
            this.buttonRecepPayment.Text = "Payment";
            this.buttonRecepPayment.UseVisualStyleBackColor = false;
            this.buttonRecepPayment.Click += new System.EventHandler(this.buttonRecepPayment_Click);
            // 
            // buttonRecepPatient
            // 
            this.buttonRecepPatient.BackColor = System.Drawing.Color.Black;
            this.buttonRecepPatient.FlatAppearance.BorderSize = 0;
            this.buttonRecepPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonRecepPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecepPatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecepPatient.ForeColor = System.Drawing.Color.White;
            this.buttonRecepPatient.Location = new System.Drawing.Point(6, 307);
            this.buttonRecepPatient.Name = "buttonRecepPatient";
            this.buttonRecepPatient.Size = new System.Drawing.Size(189, 49);
            this.buttonRecepPatient.TabIndex = 6;
            this.buttonRecepPatient.Text = "Patients";
            this.buttonRecepPatient.UseVisualStyleBackColor = false;
            this.buttonRecepPatient.Click += new System.EventHandler(this.buttonRecepPatient_Click);
            // 
            // buttonRecepReserve
            // 
            this.buttonRecepReserve.BackColor = System.Drawing.Color.Black;
            this.buttonRecepReserve.FlatAppearance.BorderSize = 0;
            this.buttonRecepReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonRecepReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecepReserve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecepReserve.ForeColor = System.Drawing.Color.White;
            this.buttonRecepReserve.Location = new System.Drawing.Point(6, 233);
            this.buttonRecepReserve.Name = "buttonRecepReserve";
            this.buttonRecepReserve.Size = new System.Drawing.Size(189, 49);
            this.buttonRecepReserve.TabIndex = 6;
            this.buttonRecepReserve.Text = "Reserve";
            this.buttonRecepReserve.UseVisualStyleBackColor = false;
            this.buttonRecepReserve.Click += new System.EventHandler(this.buttonRecepReserve_Click);
            // 
            // buttonRecepHome
            // 
            this.buttonRecepHome.BackColor = System.Drawing.Color.Black;
            this.buttonRecepHome.FlatAppearance.BorderSize = 0;
            this.buttonRecepHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonRecepHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecepHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecepHome.ForeColor = System.Drawing.Color.White;
            this.buttonRecepHome.Location = new System.Drawing.Point(6, 159);
            this.buttonRecepHome.Name = "buttonRecepHome";
            this.buttonRecepHome.Size = new System.Drawing.Size(189, 49);
            this.buttonRecepHome.TabIndex = 6;
            this.buttonRecepHome.Text = "Home";
            this.buttonRecepHome.UseVisualStyleBackColor = false;
            this.buttonRecepHome.Click += new System.EventHandler(this.buttonRecepHome_Click);
            // 
            // userControlRecepReserve1
            // 
            this.userControlRecepReserve1.BackColor = System.Drawing.Color.Black;
            this.userControlRecepReserve1.Location = new System.Drawing.Point(203, 132);
            this.userControlRecepReserve1.Name = "userControlRecepReserve1";
            this.userControlRecepReserve1.Size = new System.Drawing.Size(729, 492);
            this.userControlRecepReserve1.TabIndex = 13;
            // 
            // userControlRecepPayment1
            // 
            this.userControlRecepPayment1.BackColor = System.Drawing.Color.Black;
            this.userControlRecepPayment1.Location = new System.Drawing.Point(207, 132);
            this.userControlRecepPayment1.Name = "userControlRecepPayment1";
            this.userControlRecepPayment1.Size = new System.Drawing.Size(733, 482);
            this.userControlRecepPayment1.TabIndex = 12;
            // 
            // userControlRecepPatients1
            // 
            this.userControlRecepPatients1.BackColor = System.Drawing.Color.Black;
            this.userControlRecepPatients1.Location = new System.Drawing.Point(203, 132);
            this.userControlRecepPatients1.Name = "userControlRecepPatients1";
            this.userControlRecepPatients1.Size = new System.Drawing.Size(729, 482);
            this.userControlRecepPatients1.TabIndex = 11;
            // 
            // userControlRecepHome1
            // 
            this.userControlRecepHome1.BackColor = System.Drawing.Color.Black;
            this.userControlRecepHome1.Location = new System.Drawing.Point(203, 132);
            this.userControlRecepHome1.Name = "userControlRecepHome1";
            this.userControlRecepHome1.Size = new System.Drawing.Size(729, 492);
            this.userControlRecepHome1.TabIndex = 10;
            // 
            // Receptionist_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 636);
            this.Controls.Add(this.userControlRecepReserve1);
            this.Controls.Add(this.userControlRecepPayment1);
            this.Controls.Add(this.userControlRecepPatients1);
            this.Controls.Add(this.userControlRecepHome1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receptionist_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist_Portal";
            this.Load += new System.EventHandler(this.Receptionist_Portal_Load);
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
        private System.Windows.Forms.Button buttonRecepPayment;
        private System.Windows.Forms.Button buttonRecepPatient;
        private System.Windows.Forms.Button buttonRecepReserve;
        private System.Windows.Forms.Button buttonRecepHome;
        private UserControlRecepHome userControlRecepHome1;
        private UserControlRecepPatients userControlRecepPatients1;
        private UserControlRecepPayment userControlRecepPayment1;
        private UserControlRecepReserve userControlRecepReserve1;
    }
}