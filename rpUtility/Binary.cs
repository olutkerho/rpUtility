using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace rpUtility {
    public static class Binary {
        private static string NPCFile = Directory.GetCurrentDirectory() + "\\NPC.dat";
        private static string LocationFile = Directory.GetCurrentDirectory() + "\\Locations.dat";
        private static string AllianceFile = Directory.GetCurrentDirectory() + "\\Alliances.dat";
        private static string SkillFile = Directory.GetCurrentDirectory() + "\\Skills.dat";
        private static string MainSkillFile = Directory.GetCurrentDirectory() + "\\MainSkills.dat";
        private static List<Alliance> Alliances;
        private static List<NPC> NPCs;
        private static List<Location> Locations;
        private static List<Skill> Skills;
        private static List<string> MainSkills;

        public static void saveLists() {
            SerializeAlliance(Alliances);
            SerializeLocation(Locations);
            SerializeNPC(NPCs);
            SerializeSkill(Skills);
            SerializeMainSkills(MainSkills);
        }

        public static void addAlliance(Alliance alliance) {
            Alliances.Add(alliance);
        }

        public static void addNPC(NPC npc) {
            NPCs.Add(npc);
        }

        public static void addLocation(Location location) {
            Locations.Add(location);
        }

        public static void addSkill(Skill skill) {
            if (skill.getMainSkill() != "" && skill.getName() != "") {
                Skills.Add(skill);
            }
        }

        public static void removeAlliance(Alliance alliance) {
            if (Alliances.Contains(alliance)) {
                try {
                    Alliances.RemoveAt(Alliances.IndexOf(alliance));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeNPC(NPC npc) {
            if (NPCs.Contains(npc)) {
                try {
                    NPCs.RemoveAt(NPCs.IndexOf(npc));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeLocation(Location location) {
            if (Locations.Contains(location)) {
                try {
                    Locations.RemoveAt(Locations.IndexOf(location));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeSkill(Skill skill) {
            if (Skills.Contains(skill)) {
                try {
                    Skills.RemoveAt(Skills.IndexOf(skill));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeSkill(int index) {
            if (Skills.Count() >= index) {
                try {
                    Skills.RemoveAt(index);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeMainSkill(int index) {
            if (MainSkills.Count() >= index) {
                try {
                    MainSkills.RemoveAt(index);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void createLists() {
            Alliances = new List<Alliance>();
            NPCs = new List<NPC>();
            Locations = new List<Location>();
            Skills = new List<Skill>();
            MainSkills = new List<string>();
        }

        public static void readAlliances() {
            Alliances = DeserializeAlliance();
            if (Alliances == null) {
                Alliances = new List<Alliance>();
            }
        }

        public static void readNPCs() {
            NPCs = DeserializeNPC();
            if (NPCs == null) {
                NPCs = new List<NPC>();
            }
        }

        public static void readMainSkills() {
            MainSkills = DeserializeMainSkills();
            if (MainSkills == null) {
                MainSkills = new List<string>();
            }
        }

        public static void readLocations() {
            Locations = DeserializeLocation();
            if (Locations == null) {
                Locations = new List<Location>();
            }
        }

        public static void readSkills() {
            Skills = DeserializeSkill();
            if (Skills == null) {
                Skills = new List<Skill>();
            }
        }

        public static List<NPC> DeserializeNPC() {
            if (System.IO.File.Exists(NPCFile)) {
                using (var file = System.IO.File.OpenRead(NPCFile)) {
                    var reader = new BinaryFormatter();
                    return (List<NPC>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeNPC(List<NPC> input) {
            using (var file = System.IO.File.OpenWrite(NPCFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, NPCs);
            }
        }

        public static List<Location> DeserializeLocation() {
            if (System.IO.File.Exists(LocationFile)) {
                using (var file = System.IO.File.OpenRead(LocationFile)) {
                    var reader = new BinaryFormatter();
                    return (List<Location>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeLocation(List<Location> input) {
            using (var file = System.IO.File.OpenWrite(LocationFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, Locations);
            }
        }

        public static List<Alliance> DeserializeAlliance() {
            if (System.IO.File.Exists(AllianceFile)) {
                using (var file = System.IO.File.OpenRead(AllianceFile)) {
                    var reader = new BinaryFormatter();
                    return (List<Alliance>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeAlliance(List<Alliance> input) {
            using (var file = System.IO.File.OpenWrite(AllianceFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, Alliances);
            }
        }

        public static List<Skill> DeserializeSkill() {
            if (System.IO.File.Exists(SkillFile)) {
                using (var file = System.IO.File.OpenRead(SkillFile)) {
                    var reader = new BinaryFormatter();
                    return (List<Skill>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeSkill(List<Skill> input) {
            sortSkills();
            using (var file = System.IO.File.OpenWrite(SkillFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, Skills);
            }
        }

        public static List<Skill> CloneSkills() {
            List<Skill> skills = new List<Skill>();
            foreach (Skill s in Skills) {
                Skill ss = new Skill();
                ss.setName(s.getName());
                ss.setMainSkill(s.getMainSkill());
                skills.Add(ss);
            }
            return skills;
        }

        public static List<NPC> getNPCs() {
            return NPCs;
        }

        public static NPC findNPC(int id) {
            NPC ret = null;
            if (NPCs.Exists(npc => npc.getID() == id)) {
                ret = NPCs[NPCs.FindIndex(npc => npc.getID() == id)];
            }
            return ret;
        }

        public static void sortSkills() {
            List<Skill> skills = Skills.OrderBy(skill => skill.getName()).ToList();
            Skills = new List<Skill>();
            foreach (string ss in MainSkills) {
                foreach (Skill s in skills) {
                    if (ss == s.getMainSkill()) {
                        Skills.Add(s);
                    }
                }
            }
        }

        public static List<string> DeserializeMainSkills() {
            if (System.IO.File.Exists(MainSkillFile)) {
                using (var file = System.IO.File.OpenRead(MainSkillFile)) {
                    var reader = new BinaryFormatter();
                    return (List<string>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeMainSkills (List<string> input) {
            using (var file = System.IO.File.OpenWrite(MainSkillFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, MainSkills);
            }
        }

        public static List<string> getMainSkills() {
            List<string> ret = new List<string>();
            foreach (string s in MainSkills) {
                ret.Add(s);
            }
            return ret;
        }

        public static void addMainSkills(string name) {
            bool pass = true;
            foreach (string s in MainSkills) {
                if (name.ToLower() == s.ToLower()) {
                    pass = false;
                }
            }
            if (name == null || name == "") {
                pass = false;
            }
            if (pass) {
                MainSkills.Add(name);
            }
        }
    }
}
