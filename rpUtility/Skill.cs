using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    class Skill {
        private string Name;
        private string MainSkill;

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

        public void setMainSkill(string mainskill) {
            MainSkill = mainskill;
        }

        public string getMainSkill() {
            string ret = "";
            if (MainSkill != null) {
                ret = MainSkill;
            }
            return ret;
        }        
    }
}
