using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    [Serializable]
    public class Relations {
        private string Name;
        private string Opinion;
        private string FirstMet;
        private List<string> KnownTraits;
        private List<string> KnownSecrets;

        public Relations() {
            KnownTraits = new List<string>();
            KnownSecrets = new List<string>();
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

        public void setOpinion(string opinion) {
            Opinion = opinion;
        }

        public string getOpinion() {
            string ret = "";
            if (Opinion != null) {
                ret = Opinion;
            }
            return ret;
        }

        public void setFirstMet(string firstmet) {
            FirstMet = firstmet;
        }

        public string getFirstMet() {
            string ret = "";
            if (FirstMet != null) {
                ret = FirstMet;
            }
            return ret;
        }

        public void addKnownTrait(string knowntrait) {
            KnownTraits.Add(knowntrait);
        }

        public void removeKnownTrait(string knowntrait) {
            if (KnownTraits.Contains(knowntrait)) {
                try {
                    KnownTraits.RemoveAt(KnownTraits.IndexOf(knowntrait));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void addKnownSecret(string knownsecret) {
            KnownSecrets.Add(knownsecret);
        }

        public void removeKnownSecret(string knownsecret) {
            if (KnownSecrets.Contains(knownsecret)) {
                try {
                    KnownSecrets.RemoveAt(KnownSecrets.IndexOf(knownsecret));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
