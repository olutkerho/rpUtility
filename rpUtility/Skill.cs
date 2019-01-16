using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    class Skill {
        private string Name;
        private int Bonus;

        public Skill() {
        }

        public void setName(string name) {
            Name = name;
        }

        public string getName() {
            string ret = "";
            if (Name != null) {
                ret = Name;
            }
            return ret;
        }

        public void setBonus(int bonus) {
            Bonus = bonus;
        }

        public int getBonus() {
            return Bonus;
        }
    }
}
