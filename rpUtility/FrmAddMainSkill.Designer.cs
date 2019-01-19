namespace rpUtility {
    partial class FrmAddMainSkill {
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
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteSkills = new System.Windows.Forms.Button();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main skill name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 20);
            this.tbName.TabIndex = 1;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // flpSkills
            // 
            this.flpSkills.Location = new System.Drawing.Point(252, 10);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(200, 400);
            this.flpSkills.TabIndex = 9;
            // 
            // btnDeleteSkills
            // 
            this.btnDeleteSkills.Location = new System.Drawing.Point(16, 172);
            this.btnDeleteSkills.Name = "btnDeleteSkills";
            this.btnDeleteSkills.Size = new System.Drawing.Size(214, 94);
            this.btnDeleteSkills.TabIndex = 8;
            this.btnDeleteSkills.Text = "Delete selected";
            this.btnDeleteSkills.UseVisualStyleBackColor = true;
            this.btnDeleteSkills.Click += new System.EventHandler(this.btnDeleteSkills_Click);
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Location = new System.Drawing.Point(16, 72);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(214, 94);
            this.btnAddSkill.TabIndex = 7;
            this.btnAddSkill.Text = "Add skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // FrmAddMainSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpSkills);
            this.Controls.Add(this.btnDeleteSkills);
            this.Controls.Add(this.btnAddSkill);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddMainSkill";
            this.Text = "FrmAddMainSkill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.Button btnDeleteSkills;
        private System.Windows.Forms.Button btnAddSkill;
    }
}