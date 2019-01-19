namespace rpUtility {
    partial class FrmAddRoleplayInfo {
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
            this.tbVoiceType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTalkSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGestures = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAccent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbVoiceType
            // 
            this.tbVoiceType.Location = new System.Drawing.Point(79, 12);
            this.tbVoiceType.Multiline = true;
            this.tbVoiceType.Name = "tbVoiceType";
            this.tbVoiceType.Size = new System.Drawing.Size(400, 88);
            this.tbVoiceType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voice Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Talk Speed";
            // 
            // tbTalkSpeed
            // 
            this.tbTalkSpeed.Location = new System.Drawing.Point(79, 106);
            this.tbTalkSpeed.Multiline = true;
            this.tbTalkSpeed.Name = "tbTalkSpeed";
            this.tbTalkSpeed.Size = new System.Drawing.Size(400, 88);
            this.tbTalkSpeed.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gestures";
            // 
            // tbGestures
            // 
            this.tbGestures.Location = new System.Drawing.Point(79, 294);
            this.tbGestures.Multiline = true;
            this.tbGestures.Name = "tbGestures";
            this.tbGestures.Size = new System.Drawing.Size(400, 88);
            this.tbGestures.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Accent";
            // 
            // tbAccent
            // 
            this.tbAccent.Location = new System.Drawing.Point(79, 200);
            this.tbAccent.Multiline = true;
            this.tbAccent.Name = "tbAccent";
            this.tbAccent.Size = new System.Drawing.Size(400, 88);
            this.tbAccent.TabIndex = 4;
            // 
            // FrmAddRoleplayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGestures);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAccent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTalkSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVoiceType);
            this.Name = "FrmAddRoleplayInfo";
            this.Text = "FrmAddRoleplayInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddRoleplayInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVoiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTalkSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGestures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAccent;
    }
}