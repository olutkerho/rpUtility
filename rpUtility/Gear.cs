using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    class Gear {
        private string Name;
        private string Nick;
        private int Value;
        private bool IsStolen;
        private int Weight;
        private bool IsMagical;
        private string MagicDesc;
        private bool IsCursed;
        private string CurseDesc;

        public Gear() {
            
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

        public void setNick(string nick) {
            Nick = nick;
        }

        public string getNick() {
            string ret = "";
            if (Nick != null) {
                ret = Nick;
            }
            return ret;
        }

        public void setMagicDesc(string magicdesc) {
            MagicDesc = magicdesc;
        }

        public string getMagicDesc() {
            string ret = "";
            if (MagicDesc != null) {
                ret = MagicDesc;
            }
            return ret;
        }

        public void setCurseDesc(string cursedesc) {
            CurseDesc = cursedesc;
        }

        public string getCurseDesc() {
            string ret = "";
            if (CurseDesc != null) {
                ret = CurseDesc;
            }
            return ret;
        }

        public void setValue(int value) {
            Value = value;
        }

        public int getValue() {
            int ret = -1;
            if (Value != -1) {
                ret = Value;
            }
            return ret;
        }

        public void setWeight(int weight) {
            Weight = weight;
        }

        public int getWeight() {
            int ret = -1;
            if (Weight != -1) {
                ret = Weight;
            }
            return ret;
        }

        public void setIsStolen(bool isstolen) {
            IsStolen = isstolen;
        }

        public bool getIsStolen() {
            return IsStolen;
        }

        public void setIsMagical(bool ismagical) {
            IsMagical = ismagical;
        }

        public bool getIsMagical() {
            return IsMagical;
        }

        public void setIsCursed(bool iscursed) {
            IsCursed = iscursed;
        }

        public bool getIsCursed() {
            return IsCursed;
        }
    }
}
