namespace rpUtility {
    partial class FrmNPCSkills {
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
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSetSkills = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpSkills
            // 
            this.flpSkills.Location = new System.Drawing.Point(12, 12);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(200, 400);
            this.flpSkills.TabIndex = 0;
            // 
            // btnSetSkills
            // 
            this.btnSetSkills.Location = new System.Drawing.Point(12, 422);
            this.btnSetSkills.Name = "btnSetSkills";
            this.btnSetSkills.Size = new System.Drawing.Size(199, 55);
            this.btnSetSkills.TabIndex = 1;
            this.btnSetSkills.Text = "set skills";
            this.btnSetSkills.UseVisualStyleBackColor = true;
            this.btnSetSkills.Click += new System.EventHandler(this.btnSetSkills_Click);
            // 
            // FrmNPCSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 504);
            this.Controls.Add(this.btnSetSkills);
            this.Controls.Add(this.flpSkills);
            this.Name = "FrmNPCSkills";
            this.Text = "FrmNPCSkills";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.Button btnSetSkills;
    }
}