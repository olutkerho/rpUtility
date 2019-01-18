using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    public partial class FrmNPCSkills : Form {
        public FrmNPCSkills() {
            InitializeComponent();
            List<Skill> skills = Binary.CloneSkills();
            foreach (Skill s in skills) {
                Label lb = new Label();
                lb.Size = new Size(150, 15);
                lb.Margin = new Padding(0, 3, 0, 3);
                lb.TextAlign = ContentAlignment.TopLeft;
                lb.ForeColor = Color.Black;
                lb.Text = s.getName();
                flpSkills.Controls.Add(lb);

                CheckBox cb = new CheckBox();
                cb.Size = new Size(15, 15);
                cb.Margin = new Padding(0, 3, 0, 3);
                cb.TextAlign = ContentAlignment.TopLeft;
                cb.ForeColor = Color.Black;
                flpSkills.Controls.Add(cb);
            }
        }

        private void btnSetSkills_Click(object sender, EventArgs e) {
            List<int> index = new List<int>();
            CheckBox cb = new CheckBox();
            List<Control> controls = new List<Control>();
            foreach (Control ct in flpSkills.Controls) {
                if (ct.GetType() == cb.GetType()) {
                    controls.Add(ct);
                    foreach (CheckBox c in controls) {
                        if (c.Checked) {
                            index.Add(flpSkills.Controls.IndexOf(ct));
                        }
                    }
                    controls = new List<Control>();
                }
            }
        }
    }
}
