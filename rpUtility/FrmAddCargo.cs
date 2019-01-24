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
    public partial class FrmAddCargo : Form {
        public FrmAddCargo(List<Cargo> CargoList) {
            InitializeComponent();
            this.CargoList = CargoList;
        }

        List<Cargo> CargoList;

        private void btnAdd_Click(object sender, EventArgs e) {
            Cargo Cargo = new Cargo(tbName.Text, tbNick.Text, int.Parse(tbCapacity.Text), cbAttachable.Checked);
            CargoList.Add(Cargo);
        }
    }
}
