using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    [Serializable]
    public class Gear {
        private string _name; //Esineen uniikki nimi (toimii tunnisteena)
        private string _nick;//Esineen uniikki lempinimi (toimii tunnisteena jos ei tyhjä)
        private string _stolenFrom;//Jos on varastettu, niin keneltä
        private string _magicDesc;//Jos on taikaa, niin mitä tekee
        private string _curseDesc;//Jos on kirottu, niin mitä tekee
        private int _amount;//Montako samaa esinettä, jos esineellä on lempinimi, esineen maksimimäärä on 1
        public int Value { get; private set; }//Esineen arvo
        public int Weight { get; private set; }//Esineen paino
        public bool Magical { get; private set; }//Onko esineessä taikaa
        public bool Cursed { get; private set; }//Onko esine kirottu
        public bool Stolen { get; set; }//Onko esine varastettu

        public Gear(string Name, string Nick, int Value, int Weight, int Amount, bool Stolen, string StolenFrom, bool Magical, string MagicDesc, bool Cursed, string CurseDesc) {
            this.Name = Name;
            this.Nick = Nick;
            this.Value = Value;
            this.Weight = Weight;
            this.Amount = Amount;
            this.Stolen = Stolen;
            this.StolenFrom = StolenFrom;
            this.Magical = Magical;
            this.MagicDesc = MagicDesc;
            this.Cursed = Cursed;
            this.CurseDesc = CurseDesc;
        }

        public int Amount {
            get { return _amount; }
            set { if (_nick != "" && value > 1) { _amount = 1; MessageBox.Show("You can only have one item for nickname"); } else _amount = value; }
        }

        public string Name {
            get { return _name; }
            private set { _name = checkString(value); }
        }
        public string Nick {
            get { return _nick; }
            set { _nick = checkString(value); }
        }
        public string StolenFrom {
            get { return _stolenFrom; }
            private set { _stolenFrom = checkString(value); }
        }
        public string MagicDesc {
            get { return _magicDesc; }
            private set { _magicDesc = checkString(value); }
        }
        public string CurseDesc {
            get { return _curseDesc; }
            private set { _curseDesc = checkString(value); }
        }

        //Tarkistus, ettei yksikään string ole null
        private string checkString(string s) {
            string ret = "";
            if (s != null) {
                ret = s;
            }
            return ret;
        }
    }
}
