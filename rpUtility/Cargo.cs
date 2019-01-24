using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    public class Cargo {
        private string _name; //Uniikki nimi tavaroille
        public int Capacity { get; private set; } //Kantokapasiteetti paunoissa(lb)
        public bool Attachable { get; private set; } //Voiko kiinnittää reppuun tai vyölle, esim jos on pieni pussi
        public bool Carried { get; set; }
        private string _nick; //Jos haluaa nimetä tärkeän esineen
        private List<Gear> _gearList; //Jokaisen tavaratilan sisältö
        public bool Full { get; private set; } //Onko täynnä

        public Cargo(string Name, string Nick, int Capacity, bool Attachable) {
            this.Name = Name;
            this.Nick = Nick;
            this.Capacity = Capacity;
            this.Attachable = Attachable;
            _gearList = new List<Gear>();
        }

        public double GearWeight {
            get { return calculateWeight(); }
        }
        public string Name {
            get { return _name; }
            private set { _name = checkString(value); }
        }
        public string Nick {
            get { return _nick; }
            set { _nick = checkString(value); }
        }
        public List<Gear> GearList {
            get { return _gearList; }
            set {
                if (checkIfFits(value)) {
                    _gearList = value;
                }
                else {
                    MessageBox.Show("Item doesn't fit there");
                }
            }
        }

        //tarkistaa että stringien arvoksi ei tule null
        private string checkString(string s) {
            string ret = "";
            if (s != null) {
                ret = s;
            }
            return ret;
        }

        //laskee tavaratilan sisältämien esineiden painon
        private double calculateWeight() {
            double ret = 0;
            foreach (Gear g in _gearList) {
                ret = ret + g.Weight * g.Amount;
            }
            return ret;
        }

        //tarkistus että esine mahtuu
        public bool checkIfFits(List<Gear> g) {
            bool ret = false;
            if (calculateWeight() <= Capacity) {
                ret = true;
            }
            return ret;
        }

        //laskee paljonko tyhjää tilaa on
        public double getSpace() {
            return Capacity - calculateWeight();
        }
    }
}
