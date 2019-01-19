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
    public partial class FrmAddMainSkill : Form {
        public FrmAddMainSkill() {
            InitializeComponent();
            Skills = Binary.getMainSkills();
            RefreshSkills();
        }

        List<string> Skills;

        private void RefreshSkills() {
            Binary.sortSkills();
            Skills = Binary.getMainSkills();
            flpSkills.Controls.Clear();
            foreach (string s in Skills) {
                Label lb = new Label();
                lb.Size = new Size(150, 15);
                lb.Margin = new Padding(0, 3, 0, 3);
                lb.TextAlign = ContentAlignment.TopLeft;
                lb.Text = s;
                lb.ForeColor = Color.Black;
                flpSkills.Controls.Add(lb);

                CheckBox cb = new CheckBox();
                cb.Size = new Size(15, 15);
                cb.Margin = new Padding(0, 3, 0, 3);
                cb.TextAlign = ContentAlignment.TopLeft;
                cb.ForeColor = Color.Black;
                cb.Tag = s;
                flpSkills.Controls.Add(cb);
            }
        }

        private void btnAddSkill_Click(object sender, EventArgs e) {
            Binary.addMainSkills(tbName.Text);
            RefreshSkills();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                e.Handled = true;
                btnAddSkill_Click(tbName, e);
            }
        }

        private void btnDeleteSkills_Click(object sender, EventArgs e) {
            CheckBox cb = new CheckBox();
            List<Control> controls = new List<Control>();
            foreach (Control ct in flpSkills.Controls) {
                if (ct.GetType() == cb.GetType()) {
                    controls.Add(ct);
                    foreach (CheckBox c in controls) {
                        if (c.Checked) {
                            int i = Skills.FindIndex(skill => skill == ct.Tag.ToString());
                            Binary.removeMainSkill(i);
                            Skills = Binary.getMainSkills();
                        }
                    }
                    controls = new List<Control>();
                }
            }
            RefreshSkills();
        }
    }
}
