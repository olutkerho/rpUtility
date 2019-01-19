using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility
{
    public partial class FrmCreateNPC : Form
    {
        public FrmCreateNPC()
        {
            InitializeComponent();
            AtkList = new List<Attack>();
            RefreshAttacksList();
            NPC = new NPC();
            Stats = new Stats();
        }

        NPC NPC;
        List<Attack> AtkList;
        Stats Stats;

        private void RefreshAttacksList()
        {
            flpAttacksAndSpellCasting.Controls.Clear();

            foreach (Attack a in AtkList)
            {
                Label lb = new Label();
                lb.Text = a.getName();

                Button btnDelete = new Button();
                btnDelete.Text = "Delete";
                btnDelete.Tag = a.getName();
                btnDelete.Click += new EventHandler(btnDelete_Click);

                Button btnModify = new Button();
                btnModify.Text = "Modify";
                btnModify.Tag = a.getName();
                btnModify.Click += new EventHandler(btnModify_Click);


                flpAttacksAndSpellCasting.Controls.Add(lb);
                flpAttacksAndSpellCasting.Controls.Add(btnModify);
                flpAttacksAndSpellCasting.Controls.Add(btnDelete);
                
            }
        }

        private void btnCreateNPC_Click(object sender, EventArgs e) { 
            NPC.setFirstName(tbFirstName.Text);
            if (NPC.getFirstName() != "") {
                NPC.setLastName(tbLastName.Text);
                NPC.setAge(int.Parse(mtbAge.Text));
                NPC.setRace(tbRace.Text);
                NPC.setAlignment(tbAlignment.Text);
                NPC.setSex(tbSex.Text);
                NPC.setLevel(int.Parse(mtbLevel.Text));
                Stats.setStrength(int.Parse(mtbSrength.Text));
                Stats.setDexterity(int.Parse(mtbDexterity.Text));
                Stats.setConstitution(int.Parse(mtbConstitution.Text));
                Stats.setIntelligence(int.Parse(mtbIntelligence.Text));
                Stats.setWisdom(int.Parse(mtbWisdom.Text));
                Stats.setCharisma(int.Parse(mtbCharisma.Text));
                Stats.setArmorClass(int.Parse(mtbArmorClass.Text));
                Stats.setSpeed(int.Parse(mtbSpeed.Text));
                Stats.setHpMax(int.Parse(mtbHpMax.Text));
                Stats.setHpCurrent(Stats.getHpMax());
                Stats.setHpTemp(0);
                Stats.setProficiencyBonus(int.Parse(mtbProficiencyBonus.Text));
                Stats.setStrengthMod();
                Stats.setDexterityMod();
                Stats.setConstitutionMod();
                Stats.setIntelligenceMod();
                Stats.setWisdomMod();
                Stats.setCharismaMod();
                Stats.setAttacks(AtkList);
                List<Skill> Skills = FrmNPCSkills.getNPCSkills();
                Stats.setSkills(Skills);
                NPC.setStats(Stats);

                MessageBox.Show("lisätty");
                Binary.addNPC(NPC);
                Binary.saveLists();
                NPC = new NPC();
                Stats = new Stats();
            }
            else {
                MessageBox.Show("You cannot create an npc without a first name.");
            }
        }

        private void btnSkills_Click(object sender, EventArgs e) {
            FrmNPCSkills frm = new FrmNPCSkills();
            frm.ShowDialog();
        }

        private void btnAddAttack_Click(object sender, EventArgs e)
        {
            FrmAddAttack f = new FrmAddAttack(AtkList, true, "");
            f.ShowDialog();
            RefreshAttacksList();
        }

        // Poistaa valitun attackin listasta
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            try
            {
                // hakee attackin napin tagin perusteella listasta
                AtkList.RemoveAt(AtkList.FindIndex(a => a.getName() == btn.Tag.ToString()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            FrmAddAttack f = new FrmAddAttack(AtkList, false, btn.Tag.ToString());
            f.ShowDialog();
            RefreshAttacksList();
        }

        private void clearForm() {
            tbAlignment.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbRace.Clear();
            tbSex.Clear();
            mtbAge.Clear();
            mtbArmorClass.Clear();
            mtbCharisma.Clear();
            mtbConstitution.Clear();
            mtbDexterity.Clear();
            mtbHpMax.Clear();
            mtbIntelligence.Clear();
            mtbLevel.Clear();
            mtbProficiencyBonus.Clear();
            mtbSpeed.Clear();
            mtbSrength.Clear();
            mtbWisdom.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e) {
            clearForm();
        }

        private void btnSpells_Click(object sender, EventArgs e) {
            FrmAddSpells frm = new FrmAddSpells(Stats);
            frm.ShowDialog();
        }
    }
}
