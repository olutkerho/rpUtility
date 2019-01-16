using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    class RoleplayInfo {
        private string VoiceType;
        private string TalkSpeed;
        private string Accent;
        private string Gestures;

        public RoleplayInfo() {
        }

        public void setVoiceType(string voicetype) {
            VoiceType = voicetype;
        }

        public string getVoiceType() {
            string ret = "";
            if(VoiceType != null) {
                ret = VoiceType;
            }
            return ret;
        }

        public void setTalkSpeed(string talkspeed) {
            TalkSpeed = talkspeed;
        }

        public string getTalkSpeed() {
            string ret = "";
            if (TalkSpeed != null) { 
                ret = TalkSpeed;
            }
            return ret;
        }

        public void setAccent(string accent) {
            Accent = accent;
        }

        public string getAccent() {
            string ret = "";
            if (Accent != null) {
                ret = Accent;
            }
            return ret;
        }

        public void setGestures(string gestures) {
            Gestures = gestures;
        }

        public string getGestures() {
            string ret = "";
            if (Gestures != null) {
                ret = Gestures;
            }
            return ret;
        }
    }
}
