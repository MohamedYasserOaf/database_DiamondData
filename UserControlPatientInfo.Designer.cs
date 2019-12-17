namespace Project_database
{
    partial class UserControlPatientInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pastdiagnosis = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearchMedHistory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.pastSurgeries = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allergies = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenmeds = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pastdiagnosis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastSurgeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allergies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenmeds)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientName.ForeColor = System.Drawing.Color.White;
            this.textBoxPatientName.Location = new System.Drawing.Point(185, 24);
            this.textBoxPatientName.MaximumSize = new System.Drawing.Size(143, 34);
            this.textBoxPatientName.Multiline = true;
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(143, 26);
            this.textBoxPatientName.TabIndex = 45;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(185, 69);
            this.textBoxID.MaximumSize = new System.Drawing.Size(143, 34);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(143, 27);
            this.textBoxID.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gender :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(53, 33);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(116, 20);
            this.labelID.TabIndex = 40;
            this.labelID.Text = "Patient Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Age :";
            // 
            // textBoxPatientAge
            // 
            this.textBoxPatientAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPatientAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientAge.ForeColor = System.Drawing.Color.White;
            this.textBoxPatientAge.Location = new System.Drawing.Point(276, 129);
            this.textBoxPatientAge.MaximumSize = new System.Drawing.Size(143, 34);
            this.textBoxPatientAge.Multiline = true;
            this.textBoxPatientAge.Name = "textBoxPatientAge";
            this.textBoxPatientAge.ReadOnly = true;
            this.textBoxPatientAge.Size = new System.Drawing.Size(54, 21);
            this.textBoxPatientAge.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Medical History";
            // 
            // pastdiagnosis
            // 
            this.pastdiagnosis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pastdiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastdiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.pastdiagnosis.Location = new System.Drawing.Point(73, 243);
            this.pastdiagnosis.Name = "pastdiagnosis";
            this.pastdiagnosis.ReadOnly = true;
            this.pastdiagnosis.Size = new System.Drawing.Size(144, 194);
            this.pastdiagnosis.TabIndex = 50;
            this.pastdiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // buttonSearchMedHistory
            // 
            this.buttonSearchMedHistory.BackColor = System.Drawing.Color.Black;
            this.buttonSearchMedHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearchMedHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonSearchMedHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMedHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchMedHistory.ForeColor = System.Drawing.Color.White;
            this.buttonSearchMedHistory.Location = new System.Drawing.Point(476, 53);
            this.buttonSearchMedHistory.Name = "buttonSearchMedHistory";
            this.buttonSearchMedHistory.Size = new System.Drawing.Size(99, 78);
            this.buttonSearchMedHistory.TabIndex = 51;
            this.buttonSearchMedHistory.Text = "Retrive Medical History";
            this.buttonSearchMedHistory.UseVisualStyleBackColor = false;
            this.buttonSearchMedHistory.Click += new System.EventHandler(this.buttonSearchMedHistory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.textBoxPatientAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPatientName);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(73, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 162);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient\'s Details";
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.White;
            this.gender.Location = new System.Drawing.Point(122, 128);
            this.gender.MaximumSize = new System.Drawing.Size(143, 34);
            this.gender.Multiline = true;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(67, 21);
            this.gender.TabIndex = 49;
            this.gender.TextChanged += new System.EventHandler(this.gender_TextChanged);
            // 
            // pastSurgeries
            // 
            this.pastSurgeries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pastSurgeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastSurgeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.pastSurgeries.Location = new System.Drawing.Point(523, 243);
            this.pastSurgeries.Name = "pastSurgeries";
            this.pastSurgeries.ReadOnly = true;
            this.pastSurgeries.Size = new System.Drawing.Size(144, 194);
            this.pastSurgeries.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Allergies
            // 
            this.Allergies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Allergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allergies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.Allergies.Location = new System.Drawing.Point(373, 243);
            this.Allergies.Name = "Allergies";
            this.Allergies.ReadOnly = true;
            this.Allergies.Size = new System.Drawing.Size(144, 194);
            this.Allergies.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // takenmeds
            // 
            this.takenmeds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.takenmeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenmeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.takenmeds.Location = new System.Drawing.Point(223, 243);
            this.takenmeds.Name = "takenmeds";
            this.takenmeds.ReadOnly = true;
            this.takenmeds.Size = new System.Drawing.Size(144, 194);
            this.takenmeds.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // UserControlPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.takenmeds);
            this.Controls.Add(this.Allergies);
            this.Controls.Add(this.pastSurgeries);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearchMedHistory);
            this.Controls.Add(this.pastdiagnosis);
            this.Controls.Add(this.label4);
            this.Name = "UserControlPatientInfo";
            this.Size = new System.Drawing.Size(737, 481);
            this.Load += new System.EventHandler(this.UserControlPatientInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pastdiagnosis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastSurgeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allergies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenmeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView pastdiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonSearchMedHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.DataGridView pastSurgeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView Allergies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView takenmeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
