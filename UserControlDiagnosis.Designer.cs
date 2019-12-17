namespace Project_database
{
    partial class UserControlDiagnosis
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
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.comboBoxPrescMeds = new System.Windows.Forms.ComboBox();
            this.buttonSearchMedHistory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddSurgey = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxHospitalize = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(98, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(88, 20);
            this.labelID.TabIndex = 41;
            this.labelID.Text = "Condition :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Prescribed Medicine :";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCondition.ForeColor = System.Drawing.Color.White;
            this.textBoxCondition.Location = new System.Drawing.Point(192, 17);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(181, 27);
            this.textBoxCondition.TabIndex = 47;
            // 
            // comboBoxPrescMeds
            // 
            this.comboBoxPrescMeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrescMeds.FormattingEnabled = true;
            this.comboBoxPrescMeds.Items.AddRange(new object[] {
            "med1",
            "med2"});
            this.comboBoxPrescMeds.Location = new System.Drawing.Point(261, 65);
            this.comboBoxPrescMeds.Name = "comboBoxPrescMeds";
            this.comboBoxPrescMeds.Size = new System.Drawing.Size(112, 24);
            this.comboBoxPrescMeds.TabIndex = 48;
            // 
            // buttonSearchMedHistory
            // 
            this.buttonSearchMedHistory.BackColor = System.Drawing.Color.Black;
            this.buttonSearchMedHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearchMedHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonSearchMedHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMedHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchMedHistory.ForeColor = System.Drawing.Color.White;
            this.buttonSearchMedHistory.Location = new System.Drawing.Point(551, 38);
            this.buttonSearchMedHistory.Name = "buttonSearchMedHistory";
            this.buttonSearchMedHistory.Size = new System.Drawing.Size(63, 28);
            this.buttonSearchMedHistory.TabIndex = 52;
            this.buttonSearchMedHistory.Text = "Add";
            this.buttonSearchMedHistory.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 38);
            this.label4.TabIndex = 53;
            this.label4.Text = "List Of Medicine(s)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(85, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 150);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // buttonAddSurgey
            // 
            this.buttonAddSurgey.BackColor = System.Drawing.Color.Black;
            this.buttonAddSurgey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddSurgey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonAddSurgey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSurgey.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSurgey.ForeColor = System.Drawing.Color.White;
            this.buttonAddSurgey.Location = new System.Drawing.Point(70, 123);
            this.buttonAddSurgey.Name = "buttonAddSurgey";
            this.buttonAddSurgey.Size = new System.Drawing.Size(166, 33);
            this.buttonAddSurgey.TabIndex = 55;
            this.buttonAddSurgey.Text = "Add Surgery";
            this.buttonAddSurgey.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(316, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 28);
            this.button2.TabIndex = 56;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 3);
            this.panel1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Hospitalize :";
            // 
            // checkBoxHospitalize
            // 
            this.checkBoxHospitalize.AutoSize = true;
            this.checkBoxHospitalize.Location = new System.Drawing.Point(357, 132);
            this.checkBoxHospitalize.Name = "checkBoxHospitalize";
            this.checkBoxHospitalize.Size = new System.Drawing.Size(80, 17);
            this.checkBoxHospitalize.TabIndex = 59;
            this.checkBoxHospitalize.Text = "checkBox1";
            this.checkBoxHospitalize.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPrescMeds);
            this.groupBox1.Controls.Add(this.textBoxCondition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(70, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 102);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient\'s condition and medicine";
            // 
            // UserControlDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxHospitalize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddSurgey);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearchMedHistory);
            this.Name = "UserControlDiagnosis";
            this.Size = new System.Drawing.Size(737, 481);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.ComboBox comboBoxPrescMeds;
        private System.Windows.Forms.Button buttonSearchMedHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonAddSurgey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxHospitalize;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
