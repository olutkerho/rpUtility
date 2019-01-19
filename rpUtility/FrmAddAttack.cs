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
    public partial class FrmAddAttack : Form
    {
        List<Attack> list;
        Attack att;

        bool isNew;
        bool ifExists;

        public FrmAddAttack(List<Attack> AtkList, bool isIt, string tag)
        {
            InitializeComponent();
            list = AtkList;
            isNew = isIt;

            if (isIt == false)
            {
                att = AtkList[AtkList.FindIndex(a => a.getName() == tag)];
                btnAdd.Text = "Save changes";

                tbName.Text = att.getName();
                tbHitBonus.Text = att.getHitBonus().ToString();
                tbDamage.Text = att.getDamage();
                tbDamageType.Text = att.getDamageType();
                tbRange.Text = att.getRange().ToString();
            }

        }

        private void modifyAtk(Attack att)
        {
            foreach(Attack a in list)
            {
                if (a.getName() == tbName.Text)
                {
                    ifExists = true;
                    MessageBox.Show("You cannot create two attacks with same name!");
                    return;
                }
            }

            att.setName(tbName.Text);
            att.setHitBonus(int.Parse(tbHitBonus.Text));
            att.setDamage(tbDamage.Text);
            att.setDamageType(tbDamageType.Text);
            att.setRange(int.Parse(tbRange.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbHitBonus.Text) || string.IsNullOrEmpty(tbDamage.Text) || string.IsNullOrEmpty(tbDamageType.Text) || string.IsNullOrEmpty(tbRange.Text))
            {
                MessageBox.Show("You cannot leave empty fields!");
                return;
            }

            if (isNew)
            {
                att = new Attack();
                modifyAtk(att);
                
                if (ifExists)
                {
                    return;
                }

                list.Add(att);
            }
            else
            {
                modifyAtk(att);

                if (ifExists)
                {
                    return;
                }
            }
            
            Close();
        }
    }
}
