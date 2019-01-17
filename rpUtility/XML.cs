using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace rpUtility {
    class XML {
        private static string NPCFile = Directory.GetCurrentDirectory() + "\\NPC.xml";
        private static string LocationFile = Directory.GetCurrentDirectory() + "\\Locations.xml";
        private static string AllianceFile = Directory.GetCurrentDirectory() + "\\Alliances.xml";
        private static List<Alliance> Alliances;
        private static List<NPC> NPCs;
        private static List<Location> Locations;

        public static void saveLists() {
            SerializeAlliance(Alliances);
            SerializeLocation(Locations);
            SerializeNPC(NPCs);
        }

        public static void addAlliance(Alliance alliance)
        {
            Alliances.Add(alliance);
        }

        public static void addNPC(NPC npc)
        {
            NPCs.Add(npc);
        }

        public static void addLocation(Location location)
        {
            Locations.Add(location);
        }

        public static void removeAlliance(Alliance alliance)
        {
            if (Alliances.Contains(alliance))
            {
                try
                {
                    Alliances.RemoveAt(Alliances.IndexOf(alliance));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeNPC(NPC npc)
        {
            if (NPCs.Contains(npc))
            {
                try
                {
                    NPCs.RemoveAt(NPCs.IndexOf(npc));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeLocation(Location location)
        {
            if (Locations.Contains(location))
            {
                try
                {
                    Locations.RemoveAt(Locations.IndexOf(location));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void createLists() {
            Alliances = new List<Alliance>();
            NPCs = new List<NPC>();
            Locations = new List<Location>();
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

        public static void readLocations() {
            Locations = DeserializeLocation();
            if (Locations == null) {
                Locations = new List<Location>();
            }
        }

        public static List<NPC> DeserializeNPC() {

            if (File.Exists(NPCFile)){
                try {
                    StreamReader sr = new StreamReader(NPCFile);
                    XmlSerializer ser = new XmlSerializer(typeof(List<NPC>));
                    object obj = ser.Deserialize(sr);
                    sr.Close();
                    return (List<NPC>)obj;
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeNPC(List<NPC> input) {
            try {
                XmlSerializer ser = new XmlSerializer(input.GetType());
                StreamWriter sw = new StreamWriter(NPCFile);
                ser.Serialize(sw, input);
                sw.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Location> DeserializeLocation() {

            if (File.Exists(LocationFile)) {
                try {
                    StreamReader sr = new StreamReader(LocationFile);
                    XmlSerializer ser = new XmlSerializer(typeof(List<Location>));
                    object obj = ser.Deserialize(sr);
                    sr.Close();
                    return (List<Location>)obj;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeLocation(List<Location> input) {
            try {
                XmlSerializer ser = new XmlSerializer(input.GetType());
                StreamWriter sw = new StreamWriter(LocationFile);
                ser.Serialize(sw, input);
                sw.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Alliance> DeserializeAlliance() {

            if (File.Exists(AllianceFile)) {
                try {
                    StreamReader sr = new StreamReader(AllianceFile);
                    XmlSerializer ser = new XmlSerializer(typeof(List<Alliance>));
                    object obj = ser.Deserialize(sr);
                    sr.Close();
                    return (List<Alliance>)obj;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeAlliance(List<Alliance> input) {
            try {
                XmlSerializer ser = new XmlSerializer(input.GetType());
                StreamWriter sw = new StreamWriter(AllianceFile);
                ser.Serialize(sw, input);
                sw.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
