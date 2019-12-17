namespace Project_database
{
    partial class UserControlRecepHome
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewFilterDoctors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRecepResetFilter = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRecepDoctorName = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAvailableOpRooms = new System.Windows.Forms.TextBox();
            this.textBoxAvailableRooms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxShowAvailable = new System.Windows.Forms.CheckBox();
            this.buttonRecepFilterDoctors = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilterDoctors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(277, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 38);
            this.label4.TabIndex = 54;
            this.label4.Text = "Filter  Doctors";
            // 
            // dataGridViewFilterDoctors
            // 
            this.dataGridViewFilterDoctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dataGridViewFilterDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilterDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewFilterDoctors.Location = new System.Drawing.Point(58, 62);
            this.dataGridViewFilterDoctors.Name = "dataGridViewFilterDoctors";
            this.dataGridViewFilterDoctors.Size = new System.Drawing.Size(631, 225);
            this.dataGridViewFilterDoctors.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // buttonRecepResetFilter
            // 
            this.buttonRecepResetFilter.BackColor = System.Drawing.Color.Black;
            this.buttonRecepResetFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRecepResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonRecepResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecepResetFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecepResetFilter.ForeColor = System.Drawing.Color.White;
            this.buttonRecepResetFilter.Location = new System.Drawing.Point(603, 31);
            this.buttonRecepResetFilter.Name = "buttonRecepResetFilter";
            this.buttonRecepResetFilter.Size = new System.Drawing.Size(86, 25);
            this.buttonRecepResetFilter.TabIndex = 56;
            this.buttonRecepResetFilter.Text = "Reset Filter";
            this.buttonRecepResetFilter.UseVisualStyleBackColor = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(146, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(68, 20);
            this.labelID.TabIndex = 57;
            this.labelID.Text = "Doctor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Department :";
            // 
            // comboBoxRecepDoctorName
            // 
            this.comboBoxRecepDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecepDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRecepDoctorName.FormattingEnabled = true;
            this.comboBoxRecepDoctorName.ItemHeight = 18;
            this.comboBoxRecepDoctorName.Items.AddRange(new object[] {
            "med1",
            "med2"});
            this.comboBoxRecepDoctorName.Location = new System.Drawing.Point(230, 14);
            this.comboBoxRecepDoctorName.Name = "comboBoxRecepDoctorName";
            this.comboBoxRecepDoctorName.Size = new System.Drawing.Size(157, 26);
            this.comboBoxRecepDoctorName.TabIndex = 59;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Items.AddRange(new object[] {
            "med1",
            "med2"});
            this.comboBox1.Location = new System.Drawing.Point(230, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 26);
            this.comboBox1.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Number of available rooms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Number of available operating rooms :";
            // 
            // textBoxAvailableOpRooms
            // 
            this.textBoxAvailableOpRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAvailableOpRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxAvailableOpRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvailableOpRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailableOpRooms.ForeColor = System.Drawing.Color.White;
            this.textBoxAvailableOpRooms.Location = new System.Drawing.Point(322, 140);
            this.textBoxAvailableOpRooms.Multiline = true;
            this.textBoxAvailableOpRooms.Name = "textBoxAvailableOpRooms";
            this.textBoxAvailableOpRooms.Size = new System.Drawing.Size(65, 26);
            this.textBoxAvailableOpRooms.TabIndex = 63;
            this.textBoxAvailableOpRooms.TextChanged += new System.EventHandler(this.textBoxCondition_TextChanged);
            // 
            // textBoxAvailableRooms
            // 
            this.textBoxAvailableRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAvailableRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailableRooms.ForeColor = System.Drawing.Color.White;
            this.textBoxAvailableRooms.Location = new System.Drawing.Point(322, 98);
            this.textBoxAvailableRooms.Multiline = true;
            this.textBoxAvailableRooms.Name = "textBoxAvailableRooms";
            this.textBoxAvailableRooms.Size = new System.Drawing.Size(65, 26);
            this.textBoxAvailableRooms.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(487, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Show Available :";
            // 
            // checkBoxShowAvailable
            // 
            this.checkBoxShowAvailable.AutoSize = true;
            this.checkBoxShowAvailable.Location = new System.Drawing.Point(624, 318);
            this.checkBoxShowAvailable.Name = "checkBoxShowAvailable";
            this.checkBoxShowAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShowAvailable.TabIndex = 66;
            this.checkBoxShowAvailable.UseVisualStyleBackColor = true;
            // 
            // buttonRecepFilterDoctors
            // 
            this.buttonRecepFilterDoctors.BackColor = System.Drawing.Color.Black;
            this.buttonRecepFilterDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRecepFilterDoctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonRecepFilterDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecepFilterDoctors.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecepFilterDoctors.ForeColor = System.Drawing.Color.White;
            this.buttonRecepFilterDoctors.Location = new System.Drawing.Point(522, 379);
            this.buttonRecepFilterDoctors.Name = "buttonRecepFilterDoctors";
            this.buttonRecepFilterDoctors.Size = new System.Drawing.Size(85, 51);
            this.buttonRecepFilterDoctors.TabIndex = 67;
            this.buttonRecepFilterDoctors.Text = "Filter";
            this.buttonRecepFilterDoctors.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAvailableRooms);
            this.groupBox1.Controls.Add(this.textBoxAvailableOpRooms);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBoxRecepDoctorName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(58, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 182);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Info";
            // 
            // UserControlRecepHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRecepFilterDoctors);
            this.Controls.Add(this.checkBoxShowAvailable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRecepResetFilter);
            this.Controls.Add(this.dataGridViewFilterDoctors);
            this.Controls.Add(this.label4);
            this.Name = "UserControlRecepHome";
            this.Size = new System.Drawing.Size(737, 492);
            this.Load += new System.EventHandler(this.UserControlRecepHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilterDoctors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewFilterDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonRecepResetFilter;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRecepDoctorName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAvailableOpRooms;
        private System.Windows.Forms.TextBox textBoxAvailableRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxShowAvailable;
        private System.Windows.Forms.Button buttonRecepFilterDoctors;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
