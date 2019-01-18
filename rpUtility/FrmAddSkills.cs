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
    public partial class FrmAddSkills : Form {
        public FrmAddSkills() {
            InitializeComponent();
            RefreshSkills();
        }

        List<Skill> skills;
        private void btnAddSkill_Click(object sender, EventArgs e) {
            Skill skill = new Skill();
            skill.setName(tbName.Text);
            skill.setMainSkill(tbMainSkill.Text);
            Binary.addSkill(skill);
            Binary.saveLists();
            RefreshSkills();
        }

        private void RefreshSkills() {
            skills = Binary.CloneSkills();
            flpSkills.Controls.Clear();
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
                cb.Tag = s.getName();
                flpSkills.Controls.Add(cb);
            }
        }

        private void tbMainSkill_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                e.Handled = true;
                btnAddSkill_Click(tbMainSkill, e);
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
                            int i = skills.FindIndex(skill => skill.getName() == ct.Tag.ToString());
                            Binary.removeSkill(i);
                        }
                    }
                    controls = new List<Control>();
                }
            }
            RefreshSkills();
        }
    }
}
