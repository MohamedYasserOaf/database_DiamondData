namespace Project_database
{
    partial class UserControlPharmOrder
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMedsStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRecepDoctorName = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonPharmOrderReserList = new System.Windows.Forms.Button();
            this.buttonPharmOrderAddMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPharmOrderApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPharmOrderConfirm = new System.Windows.Forms.Button();
            this.dIAMOND_HOSPITAL3DataSet = new Project_database.DIAMOND_HOSPITAL3DataSet();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableAdapter = new Project_database.DIAMOND_HOSPITAL3DataSetTableAdapters.MedicineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedsStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIAMOND_HOSPITAL3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedsStock
            // 
            this.dataGridViewMedsStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dataGridViewMedsStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedsStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewMedsStock.Location = new System.Drawing.Point(60, 284);
            this.dataGridViewMedsStock.Name = "dataGridViewMedsStock";
            this.dataGridViewMedsStock.Size = new System.Drawing.Size(614, 200);
            this.dataGridViewMedsStock.TabIndex = 57;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(141, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 38);
            this.label4.TabIndex = 58;
            this.label4.Text = "List of Medicine(s) to be ordered";
            // 
            // comboBoxRecepDoctorName
            // 
            this.comboBoxRecepDoctorName.DataSource = this.medicineBindingSource;
            this.comboBoxRecepDoctorName.DisplayMember = "M_name";
            this.comboBoxRecepDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecepDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRecepDoctorName.FormattingEnabled = true;
            this.comboBoxRecepDoctorName.ItemHeight = 18;
            this.comboBoxRecepDoctorName.Location = new System.Drawing.Point(199, 16);
            this.comboBoxRecepDoctorName.Name = "comboBoxRecepDoctorName";
            this.comboBoxRecepDoctorName.Size = new System.Drawing.Size(157, 26);
            this.comboBoxRecepDoctorName.TabIndex = 61;
            this.comboBoxRecepDoctorName.ValueMember = "M_ID";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(35, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(148, 20);
            this.labelID.TabIndex = 60;
            this.labelID.Text = "Choose Medicine :";
            // 
            // buttonPharmOrderReserList
            // 
            this.buttonPharmOrderReserList.BackColor = System.Drawing.Color.Black;
            this.buttonPharmOrderReserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPharmOrderReserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmOrderReserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmOrderReserList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmOrderReserList.ForeColor = System.Drawing.Color.White;
            this.buttonPharmOrderReserList.Location = new System.Drawing.Point(588, 253);
            this.buttonPharmOrderReserList.Name = "buttonPharmOrderReserList";
            this.buttonPharmOrderReserList.Size = new System.Drawing.Size(86, 25);
            this.buttonPharmOrderReserList.TabIndex = 62;
            this.buttonPharmOrderReserList.Text = "Reset List";
            this.buttonPharmOrderReserList.UseVisualStyleBackColor = false;
            this.buttonPharmOrderReserList.Click += new System.EventHandler(this.buttonPharmOrderReserList_Click);
            // 
            // buttonPharmOrderAddMed
            // 
            this.buttonPharmOrderAddMed.BackColor = System.Drawing.Color.Black;
            this.buttonPharmOrderAddMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPharmOrderAddMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmOrderAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmOrderAddMed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmOrderAddMed.ForeColor = System.Drawing.Color.White;
            this.buttonPharmOrderAddMed.Location = new System.Drawing.Point(244, 124);
            this.buttonPharmOrderAddMed.Name = "buttonPharmOrderAddMed";
            this.buttonPharmOrderAddMed.Size = new System.Drawing.Size(112, 38);
            this.buttonPharmOrderAddMed.TabIndex = 63;
            this.buttonPharmOrderAddMed.Text = "Add";
            this.buttonPharmOrderAddMed.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Increase Order Amount :";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCondition.ForeColor = System.Drawing.Color.White;
            this.textBoxCondition.Location = new System.Drawing.Point(94, 109);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(66, 22);
            this.textBoxCondition.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "By";
            // 
            // buttonPharmOrderApply
            // 
            this.buttonPharmOrderApply.BackColor = System.Drawing.Color.Black;
            this.buttonPharmOrderApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPharmOrderApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmOrderApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmOrderApply.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmOrderApply.ForeColor = System.Drawing.Color.White;
            this.buttonPharmOrderApply.Location = new System.Drawing.Point(85, 137);
            this.buttonPharmOrderApply.Name = "buttonPharmOrderApply";
            this.buttonPharmOrderApply.Size = new System.Drawing.Size(86, 25);
            this.buttonPharmOrderApply.TabIndex = 68;
            this.buttonPharmOrderApply.Text = "Apply";
            this.buttonPharmOrderApply.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPharmOrderApply);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCondition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonPharmOrderAddMed);
            this.groupBox1.Controls.Add(this.comboBoxRecepDoctorName);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(60, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 174);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Medicine";
            // 
            // buttonPharmOrderConfirm
            // 
            this.buttonPharmOrderConfirm.BackColor = System.Drawing.Color.Black;
            this.buttonPharmOrderConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPharmOrderConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonPharmOrderConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPharmOrderConfirm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPharmOrderConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonPharmOrderConfirm.Location = new System.Drawing.Point(539, 111);
            this.buttonPharmOrderConfirm.Name = "buttonPharmOrderConfirm";
            this.buttonPharmOrderConfirm.Size = new System.Drawing.Size(98, 71);
            this.buttonPharmOrderConfirm.TabIndex = 69;
            this.buttonPharmOrderConfirm.Text = "Order";
            this.buttonPharmOrderConfirm.UseVisualStyleBackColor = false;
            // 
            // dIAMOND_HOSPITAL3DataSet
            // 
            this.dIAMOND_HOSPITAL3DataSet.DataSetName = "DIAMOND_HOSPITAL3DataSet";
            this.dIAMOND_HOSPITAL3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.dIAMOND_HOSPITAL3DataSet;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlPharmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.buttonPharmOrderConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPharmOrderReserList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewMedsStock);
            this.Name = "UserControlPharmOrder";
            this.Size = new System.Drawing.Size(737, 526);
            this.Load += new System.EventHandler(this.UserControlPharmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedsStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIAMOND_HOSPITAL3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedsStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRecepDoctorName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonPharmOrderReserList;
        private System.Windows.Forms.Button buttonPharmOrderAddMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPharmOrderApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPharmOrderConfirm;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private DIAMOND_HOSPITAL3DataSet dIAMOND_HOSPITAL3DataSet;
        private DIAMOND_HOSPITAL3DataSetTableAdapters.MedicineTableAdapter medicineTableAdapter;
    }
}
