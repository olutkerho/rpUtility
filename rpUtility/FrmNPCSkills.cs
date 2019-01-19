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
            Skills = Binary.CloneSkills();
            foreach (Skill s in Skills) {
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
                cb.Tag = lb.Text;
                foreach (Skill skill in NPCSkills) {
                    if (skill.getName() == cb.Tag.ToString()) {
                        cb.Checked = true;
                    }
                }
                flpSkills.Controls.Add(cb);
            }
        }

        private List<Skill> Skills;
        private static List<Skill> NPCSkills = new List<Skill>();

        public static List<Skill> getNPCSkills() {
            List<Skill> skills = new List<Skill>();
            foreach (Skill s in NPCSkills) {
                Skill ss = new Skill();
                ss.setName(s.getName());
                ss.setMainSkill(s.getMainSkill());
                skills.Add(ss);
            }
            return skills;
        }

        public static void setNPCSkills(List<Skill> npcskills) {
            NPCSkills = new List<Skill>();
            foreach (Skill skill in npcskills) {
                Skill s = new Skill();
                s.setMainSkill(skill.getMainSkill());
                s.setName(skill.getName());
            }
        }

        private void btnSetSkills_Click(object sender, EventArgs e) {
            NPCSkills = new List<Skill>();
            CheckBox cb = new CheckBox();
            List<Control> controls = new List<Control>();
            foreach (Control ct in flpSkills.Controls) {
                if (ct.GetType() == cb.GetType()) {
                    controls.Add(ct);
                    foreach (CheckBox c in controls) {
                        if (c.Checked) {
                            int i = Skills.FindIndex(skill => skill.getName() == ct.Tag.ToString());
                            NPCSkills.Add(Skills[i]);
                        }
                    }
                    controls = new List<Control>();
                }
            }
        }
    }
}
