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
            npc = new NPC();
        }

        NPC npc;
        List<Attack> AtkList;

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
            npc.setFirstName(tbFirstName.Text);
            if (npc.getFirstName() != "") {
                npc.setLastName(tbLastName.Text);
                npc.setAge(int.Parse(mtbAge.Text));
                npc.setRace(tbRace.Text);
                npc.setAlignment(tbAlignment.Text);
                npc.setSex(tbSex.Text);
                npc.setLevel(int.Parse(mtbLevel.Text));
                Stats stats = new Stats();
                stats.setStrength(int.Parse(mtbSrength.Text));
                stats.setDexterity(int.Parse(mtbDexterity.Text));
                stats.setConstitution(int.Parse(mtbConstitution.Text));
                stats.setIntelligence(int.Parse(mtbIntelligence.Text));
                stats.setWisdom(int.Parse(mtbWisdom.Text));
                stats.setCharisma(int.Parse(mtbCharisma.Text));
                stats.setArmorClass(int.Parse(mtbArmorClass.Text));
                stats.setSpeed(int.Parse(mtbSpeed.Text));
                stats.setHpMax(int.Parse(mtbHpMax.Text));
                stats.setHpCurrent(stats.getHpMax());
                stats.setHpTemp(0);
                stats.setProficiencyBonus(int.Parse(mtbProficiencyBonus.Text));
                stats.setStrengthMod();
                stats.setDexterityMod();
                stats.setConstitutionMod();
                stats.setIntelligenceMod();
                stats.setWisdomMod();
                stats.setCharismaMod();
                stats.setAttacks(AtkList);
                List<Skill> Skills = FrmNPCSkills.getNPCSkills();
                stats.setSkills(Skills);
                npc.setStats(stats);

                MessageBox.Show("lisätty");
                Binary.addNPC(npc);
                Binary.saveLists();
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
    }
}
