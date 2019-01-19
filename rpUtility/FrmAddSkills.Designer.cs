namespace rpUtility {
    partial class FrmAddSkills {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.btnDeleteSkills = new System.Windows.Forms.Button();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbMainSkill = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(85, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(144, 20);
            this.tbName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Main skill";
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Location = new System.Drawing.Point(15, 80);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(214, 94);
            this.btnAddSkill.TabIndex = 2;
            this.btnAddSkill.Text = "Add skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // btnDeleteSkills
            // 
            this.btnDeleteSkills.Location = new System.Drawing.Point(15, 180);
            this.btnDeleteSkills.Name = "btnDeleteSkills";
            this.btnDeleteSkills.Size = new System.Drawing.Size(214, 94);
            this.btnDeleteSkills.TabIndex = 3;
            this.btnDeleteSkills.Text = "Delete selected";
            this.btnDeleteSkills.UseVisualStyleBackColor = true;
            this.btnDeleteSkills.Click += new System.EventHandler(this.btnDeleteSkills_Click);
            // 
            // flpSkills
            // 
            this.flpSkills.Location = new System.Drawing.Point(256, 18);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(200, 400);
            this.flpSkills.TabIndex = 6;
            // 
            // cmbMainSkill
            // 
            this.cmbMainSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainSkill.FormattingEnabled = true;
            this.cmbMainSkill.Location = new System.Drawing.Point(85, 47);
            this.cmbMainSkill.Name = "cmbMainSkill";
            this.cmbMainSkill.Size = new System.Drawing.Size(144, 21);
            this.cmbMainSkill.TabIndex = 1;
            // 
            // FrmAddSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 514);
            this.Controls.Add(this.cmbMainSkill);
            this.Controls.Add(this.flpSkills);
            this.Controls.Add(this.btnDeleteSkills);
            this.Controls.Add(this.btnAddSkill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddSkills";
            this.Text = "AddSkills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.Button btnDeleteSkills;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.ComboBox cmbMainSkill;
    }
}