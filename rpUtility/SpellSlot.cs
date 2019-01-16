using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    class SpellSlot {
        private int Level;
        private int Amount;

        public SpellSlot() {
        }

        public void setLevel(int level) {
            Level = level;
        }

        public int getLevel() {
            int ret = -1;
            if(Level != -1) {
                ret = Level;
            }
            return ret;
        }

        public void setAmount(int amount) {
            Amount = amount;
        }

        public int getAmount() {
            int ret = -1;
            if (Amount != -1) {
                ret = Amount;
            }
            return ret;
        }
    }
}
