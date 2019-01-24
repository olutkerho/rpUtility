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
    public partial class FrmInventory : Form {
        public FrmInventory(NPC npc) {
            InitializeComponent();
            NPC = npc;
            CargoList = npc.Cargo;
            RefreshCargo();
        }
        NPC NPC;
        List<Cargo> CargoList;
        int _cargoIndex;
        int index = 0;

        private void RefreshCargo() {
            RemoveExtra();
            _cargoIndex = 0;
            List<string> tags = new List<string>();
            string tag;

            Size size = new Size(60, 23);
            Size namesize = new Size(200, 23);
            Size buttonsize = new Size(23, 23);
            flpGear.Controls.Clear();

            Label lbHeadName = new Label();
            lbHeadName.Text = "Name";
            lbHeadName.Size = namesize;
            flpGear.Controls.Add(lbHeadName);

            Label lbHeadCapacity = new Label();
            lbHeadCapacity.Text = "Capacity";
            lbHeadCapacity.Size = size;
            flpGear.Controls.Add(lbHeadCapacity);

            Label lbHeadCarried = new Label();
            lbHeadCarried.Text = "Carried";
            lbHeadCarried.Size = size;
            flpGear.Controls.Add(lbHeadCarried);

            foreach (Cargo c in CargoList) {
                tag = _cargoIndex.ToString();
                Label lbName = new Label();
                if (c.Nick != "") {
                    lbName.Text = c.Nick;
                }
                else {
                    lbName.Text = c.Name;
                }
                lbName.Size = namesize;
                lbName.Tag = tag;
                lbName.Click += new EventHandler(Cargo_Click);
                flpGear.Controls.Add(lbName);
                ToolTip ttName = new ToolTip();
                ttName.SetToolTip(lbName, c.Name);

                Label lbCapacity = new Label();
                lbCapacity.Text = c.GearWeight + "/" + c.Capacity;
                lbCapacity.Size = size;
                lbCapacity.Tag = tag;
                lbCapacity.Click += new EventHandler(Cargo_Click);
                flpGear.Controls.Add(lbCapacity);
                ToolTip ttCapacity = new ToolTip();
                ttCapacity.SetToolTip(lbCapacity, "empty space: " + c.getSpace());

                Label lbCarried = new Label();
                lbCarried.Text = c.Carried.ToString();
                lbCarried.Size = size;
                lbCarried.Tag = tag;
                lbCarried.Click += new EventHandler(Cargo_Click);
                _cargoIndex++;
            }
        }

        private void RefreshGear(List<Gear> GearList) {
            Size size = new Size(45, 23);
            Size namesize = new Size(200, 23);
            Size buttonsize = new Size(23, 23);
            flpGear.Controls.Clear();

            Label lbHeadName = new Label();
            lbHeadName.Text = "Name";
            lbHeadName.Size = namesize;
            flpGear.Controls.Add(lbHeadName);

            Label lbHeadValue = new Label();
            lbHeadValue.Text = "Value";
            lbHeadValue.Size = size;
            flpGear.Controls.Add(lbHeadValue);

            Label lbHeadWeight = new Label();
            lbHeadWeight.Text = "Weight";
            lbHeadWeight.Size = size;
            flpGear.Controls.Add(lbHeadWeight);

            Label lbHeadCursed = new Label();
            lbHeadCursed.Text = "Cursed";
            lbHeadCursed.Size = size;
            flpGear.Controls.Add(lbHeadCursed);

            Label lbHeadMagic = new Label();
            lbHeadMagic.Text = "Magical";
            lbHeadMagic.Size = size;
            flpGear.Controls.Add(lbHeadMagic);

            Label lbHeadStolen = new Label();
            lbHeadStolen.Text = "Stolen";
            lbHeadStolen.Size = size;
            flpGear.Controls.Add(lbHeadStolen);

            Label lbHeadAmount = new Label();
            lbHeadAmount.Text = "Amount";
            lbHeadAmount.Size = size;
            flpGear.Controls.Add(lbHeadAmount);

            Label lbBack = new Label();
            lbBack.Text = "Back";
            lbBack.Size = size;
            lbBack.Location = new Point(lbHeadAmount.Location.X + 100, lbHeadAmount.Location.Y);
            lbBack.Click += new EventHandler(Back_Click);
            Controls.Add(lbBack);
            foreach (Gear g in GearList) {
                string tag = g.Name;
                if (g.Nick != "") {
                    tag = g.Nick;
                    Label lbName = new Label();
                    lbName.Text = g.Nick;
                    lbName.Tag = tag;
                    lbName.Size = namesize;
                    lbName.Click += new EventHandler(lbName_Click);
                    flpGear.Controls.Add(lbName);
                    ToolTip ttName = new ToolTip();
                    ttName.SetToolTip(lbName, g.Name);
                }
                else {
                    Label lbName = new Label();
                    lbName.Text = g.Name;
                    lbName.Tag = tag;
                    lbName.Size = namesize;
                    lbName.Click += new EventHandler(lbName_Click);
                    flpGear.Controls.Add(lbName);
                    ToolTip ttName = new ToolTip();
                    ttName.SetToolTip(lbName, g.Name);
                }

                Label lbValue = new Label();
                lbValue.Size = size;
                lbValue.Text = g.Value.ToString();
                lbValue.Tag = tag;
                lbValue.Click += new EventHandler(lbName_Click);
                flpGear.Controls.Add(lbValue);
                ToolTip ttValue = new ToolTip();
                ttValue.SetToolTip(lbValue, "silver");

                Label lbWeight = new Label();
                lbWeight.Size = size;
                lbWeight.Text = g.Weight.ToString();
                lbWeight.Tag = tag;
                lbWeight.Click += new EventHandler(lbName_Click);
                flpGear.Controls.Add(lbWeight);
                ToolTip ttWeight = new ToolTip();
                ttWeight.SetToolTip(lbWeight, "lb");

                Label lbCursed = new Label();
                lbCursed.Size = size;
                lbCursed.Text = g.Cursed.ToString();
                lbCursed.Tag = tag;
                lbCursed.Click += new EventHandler(lbName_Click);
                flpGear.Controls.Add(lbCursed);
                if (g.Cursed) {
                    ToolTip ttCursed = new ToolTip();
                    ttCursed.SetToolTip(lbCursed, g.CurseDesc);
                }

                Label lbMagic = new Label();
                lbMagic.Size = size;
                lbMagic.Text = g.Magical.ToString();
                lbMagic.Tag = tag;
                lbMagic.Click += new EventHandler(lbName_Click);
                flpGear.Controls.Add(lbMagic);
                if (g.Magical) {
                    ToolTip ttMagic = new ToolTip();
                    ttMagic.SetToolTip(lbMagic, g.MagicDesc);
                }

                Label lbStolen = new Label();
                lbStolen.Size = size;
                lbStolen.Text = g.Stolen.ToString();
                lbStolen.Tag = tag;
                lbStolen.Click += new EventHandler(lbName_Click);
                flpGear.Controls.Add(lbStolen);
                if (g.Stolen) {
                    ToolTip ttStolen = new ToolTip();
                    ttStolen.SetToolTip(lbStolen, g.StolenFrom);
                }

                Label lbAmount = new Label();
                lbAmount.Size = size;
                lbAmount.Text = g.Amount.ToString();
                lbAmount.Tag = tag + "amount";
                lbAmount.Click += new EventHandler(lbName_Click);
                flpGear.Controls.Add(lbAmount);

                Button btnRemove = new Button();
                btnRemove.Text = "-";
                btnRemove.Tag = tag;
                btnRemove.Size = buttonsize;
                btnRemove.Location = new Point(lbAmount.Location.X + 85, lbValue.Location.Y + 7);
                btnRemove.Click += new EventHandler(btnRemove_Click);
                Controls.Add(btnRemove);
                //flpGear.Controls.Add(btnRemove);
                ToolTip ttRemove = new ToolTip();
                ttRemove.SetToolTip(btnRemove, "Take one item");

                Button btnAdd = new Button();
                btnAdd.Text = "+";
                btnAdd.Tag = tag;
                btnAdd.Size = buttonsize;
                btnAdd.Location = new Point(btnRemove.Location.X + 33, lbValue.Location.Y + 7);
                btnAdd.Click += new EventHandler(btnAdd_Click);
                Controls.Add(btnAdd);
                //flpGear.Controls.Add(btnAdd);
                ToolTip ttAdd = new ToolTip();
                ttAdd.SetToolTip(btnAdd, "Add one item");

            }
        }

        private void RefreshAmount(string tag, int amount) {
            Label temp = new Label();
            foreach (Control c in flpGear.Controls) {
                if (c.GetType() == temp.GetType() && c.Tag != null) {
                    if (c.Tag.ToString() == tag + "amount") {
                        c.Text = amount.ToString();
                    }
                }
            }
        }

        private string CheckTags(List<string> tags, string tag) {
            int i = 1;
            string ret = tag;
            foreach (string s in tags) {
                if (i == 1 && tag == s) {
                    i++;
                }
                else if (tag + i == s) {
                    i++;
                }
            }
            if (i > 1) {
                ret = tag + i;
            }
            return ret;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            foreach (Cargo c in CargoList) {
                foreach (Gear g in c.GearList) {
                    if (g.Nick != "" && g.Nick == btn.Tag.ToString()) {
                        g.Amount = g.Amount + 1;
                        RefreshAmount(btn.Tag.ToString(), g.Amount);
                    }
                    else if (g.Name == btn.Tag.ToString()) {
                        g.Amount = g.Amount + 1;
                        RefreshAmount(btn.Tag.ToString(), g.Amount);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            bool pass = true;
            Button btn = (Button)sender;
            foreach (Cargo c in CargoList) {
                foreach (Gear g in c.GearList) {
                    if (g.Nick != "" && g.Nick == btn.Tag.ToString()) {
                        if (g.Amount > 0) {
                            g.Amount = g.Amount - 1;
                            RefreshAmount(btn.Tag.ToString(), g.Amount);
                        }
                        else {
                            pass = false;
                        }
                    }
                    else if (g.Name == btn.Tag.ToString()) {
                        if (g.Amount > 0) {
                            g.Amount = g.Amount - 1;
                            RefreshAmount(btn.Tag.ToString(), g.Amount);
                        }
                        else {
                            pass = false;
                        }
                    }
                }
            }
            if (!pass) {
                MessageBox.Show("You can't remove an item if you don't have any");
            }
        }

        private void RemoveExtra() {
            List<int> index = new List<int>();
            int i = 0;
            foreach (Control c in Controls) {
                if (c.Tag != null) {
                    index.Add(i);
                }
                i++;
            }
            index.Reverse();
            foreach (int q in index) {
                Controls.RemoveAt(q);
            }
        }

        private void lbName_Click(object sender, EventArgs e) {

        }

        private void Cargo_Click(object sender, EventArgs e) {
            Label lb = (Label)sender;
            index = int.Parse(lb.Tag.ToString());
            RefreshGear(CargoList[index].GearList);
        }

        private void btnAddGear_Click(object sender, EventArgs e) {
            FrmAddGear frm = new FrmAddGear(CargoList[index].GearList);
            frm.ShowDialog();
            RefreshGear(CargoList[index].GearList);
        }

        private void Back_Click(object sender, EventArgs e) {
            RefreshCargo();
        }

        private void btnAddContainer_Click(object sender, EventArgs e) {
            FrmAddCargo frm = new FrmAddCargo(CargoList);
            frm.ShowDialog();
            RefreshCargo();
        }
    }
}
