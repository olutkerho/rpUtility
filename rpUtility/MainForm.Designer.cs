namespace rpUtility {
    partial class MainForm {
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
            this.btnOpenStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenStats
            // 
            this.btnOpenStats.Location = new System.Drawing.Point(334, 29);
            this.btnOpenStats.Name = "btnOpenStats";
            this.btnOpenStats.Size = new System.Drawing.Size(130, 23);
            this.btnOpenStats.TabIndex = 0;
            this.btnOpenStats.Text = "open frmStats.cs";
            this.btnOpenStats.UseVisualStyleBackColor = true;
            this.btnOpenStats.Click += new System.EventHandler(this.btnOpenStats_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenStats);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenStats;
    }
}