namespace Project_database
{
    partial class Doctor_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Portal));
            this.buttonExitDoc = new System.Windows.Forms.Button();
            this.buttonMinDoc = new System.Windows.Forms.Button();
            this.labelHospName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonPatientInfo = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonDiagnosis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlSchedule1 = new Project_database.UserControlSchedule();
            this.userControlPatientInfo1 = new Project_database.UserControlPatientInfo();
            this.userControlDiagnosis1 = new Project_database.UserControlDiagnosis();
            this.userControlDocHome1 = new Project_database.UserControlDocHome();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelHospName);
            this.panel2.Controls.Add(this.buttonExitDoc);
            this.panel2.Controls.Add(this.buttonMinDoc);
            this.panel2.Location = new System.Drawing.Point(207, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 124);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOCTOR PORTAL";
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(6, 159);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(189, 49);
            this.buttonHome.TabIndex = 6;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonPatientInfo
            // 
            this.buttonPatientInfo.BackColor = System.Drawing.Color.Black;
            this.buttonPatientInfo.FlatAppearance.BorderSize = 0;
            this.buttonPatientInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientInfo.ForeColor = System.Drawing.Color.White;
            this.buttonPatientInfo.Location = new System.Drawing.Point(6, 233);
            this.buttonPatientInfo.Name = "buttonPatientInfo";
            this.buttonPatientInfo.Size = new System.Drawing.Size(189, 49);
            this.buttonPatientInfo.TabIndex = 6;
            this.buttonPatientInfo.Text = "Patient Info";
            this.buttonPatientInfo.UseVisualStyleBackColor = false;
            this.buttonPatientInfo.Click += new System.EventHandler(this.buttonPatientInfo_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.Black;
            this.buttonSchedule.FlatAppearance.BorderSize = 0;
            this.buttonSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedule.ForeColor = System.Drawing.Color.White;
            this.buttonSchedule.Location = new System.Drawing.Point(6, 307);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(189, 49);
            this.buttonSchedule.TabIndex = 6;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonDiagnosis
            // 
            this.buttonDiagnosis.BackColor = System.Drawing.Color.Black;
            this.buttonDiagnosis.FlatAppearance.BorderSize = 0;
            this.buttonDiagnosis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagnosis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiagnosis.ForeColor = System.Drawing.Color.White;
            this.buttonDiagnosis.Location = new System.Drawing.Point(6, 381);
            this.buttonDiagnosis.Name = "buttonDiagnosis";
            this.buttonDiagnosis.Size = new System.Drawing.Size(189, 49);
            this.buttonDiagnosis.TabIndex = 6;
            this.buttonDiagnosis.Text = "Diagnosis";
            this.buttonDiagnosis.UseVisualStyleBackColor = false;
            this.buttonDiagnosis.Click += new System.EventHandler(this.buttonDiagnosis_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonDiagnosis);
            this.panel1.Controls.Add(this.buttonSchedule);
            this.panel1.Controls.Add(this.buttonPatientInfo);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 633);
            this.panel1.TabIndex = 7;
            // 
            // userControlSchedule1
            // 
            this.userControlSchedule1.BackColor = System.Drawing.Color.Black;
            this.userControlSchedule1.Location = new System.Drawing.Point(203, 134);
            this.userControlSchedule1.Name = "userControlSchedule1";
            this.userControlSchedule1.Size = new System.Drawing.Size(729, 490);
            this.userControlSchedule1.TabIndex = 11;
            // 
            // userControlPatientInfo1
            // 
            this.userControlPatientInfo1.BackColor = System.Drawing.Color.Black;
            this.userControlPatientInfo1.Location = new System.Drawing.Point(207, 132);
            this.userControlPatientInfo1.Name = "userControlPatientInfo1";
            this.userControlPatientInfo1.Size = new System.Drawing.Size(725, 492);
            this.userControlPatientInfo1.TabIndex = 10;
            // 
            // userControlDiagnosis1
            // 
            this.userControlDiagnosis1.BackColor = System.Drawing.Color.Black;
            this.userControlDiagnosis1.Location = new System.Drawing.Point(203, 132);
            this.userControlDiagnosis1.Name = "userControlDiagnosis1";
            this.userControlDiagnosis1.Size = new System.Drawing.Size(729, 492);
            this.userControlDiagnosis1.TabIndex = 9;
            // 
            // userControlDocHome1
            // 
            this.userControlDocHome1.BackColor = System.Drawing.Color.Black;
            this.userControlDocHome1.Location = new System.Drawing.Point(207, 132);
            this.userControlDocHome1.Name = "userControlDocHome1";
            this.userControlDocHome1.Size = new System.Drawing.Size(725, 483);
            this.userControlDocHome1.TabIndex = 8;
            // 
            // Doctor_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 636);
            this.Controls.Add(this.userControlSchedule1);
            this.Controls.Add(this.userControlPatientInfo1);
            this.Controls.Add(this.userControlDiagnosis1);
            this.Controls.Add(this.userControlDocHome1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Portal";
            this.Load += new System.EventHandler(this.Doctor_Portal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitDoc;
        private System.Windows.Forms.Button buttonMinDoc;
        private System.Windows.Forms.Label labelHospName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDiagnosis;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonPatientInfo;
        private System.Windows.Forms.Button buttonHome;
        private UserControlDocHome userControlDocHome1;
        private UserControlDiagnosis userControlDiagnosis1;
        private UserControlPatientInfo userControlPatientInfo1;
        private UserControlSchedule userControlSchedule1;
    }
}