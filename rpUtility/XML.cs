﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace rpUtility {
    public static class XML {
        private static string NPCFile = Directory.GetCurrentDirectory() + "\\NPC";
        private static string LocationFile = Directory.GetCurrentDirectory() + "\\Locations.xml";
        private static string AllianceFile = Directory.GetCurrentDirectory() + "\\Alliances.xml";
        private static List<Alliance> Alliances;
        private static List<NPC> NPCs;
        private static List<Location> Locations;

        public static void saveLists() {
            SerializeAlliance();
            SerializeLocation();
            SerializeBinary(NPCs);
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
            NPCs = DeserializeBinary();
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

        public static void SerializeNPC() {
            try {
                XmlSerializer ser = new XmlSerializer(NPCs.GetType());
                StreamWriter sw = new StreamWriter(NPCFile);
                ser.Serialize(sw, NPCs);
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

        public static void SerializeLocation() {
            try {
                XmlSerializer ser = new XmlSerializer(Locations.GetType());
                StreamWriter sw = new StreamWriter(LocationFile);
                ser.Serialize(sw, Locations);
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

        public static void SerializeAlliance() {
            try {
                XmlSerializer ser = new XmlSerializer(Alliances.GetType());
                StreamWriter sw = new StreamWriter(AllianceFile);
                ser.Serialize(sw, Alliances);
                sw.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public static List <NPC> DeserializeBinary() {
            if (File.Exists(NPCFile)) {
                using (var file = File.OpenRead(NPCFile)) {
                    var reader = new BinaryFormatter();
                    return (List <NPC>) reader.Deserialize(file);
                }
            }
            else
                return null;
        }

        public static void SerializeBinary(List <NPC> input) {
            using (var file = File.OpenWrite(NPCFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, NPCs); // Writestheentirelist.
            }
        }
    }
}
