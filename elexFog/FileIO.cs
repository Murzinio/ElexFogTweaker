using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace elexFog
{
    enum FogType
    {
        Removed,
        Adjusted,
        Default
    }

    class FileIO
    {
        private const string m_removedDepth = "1";
        private const string m_removedMaxViewRange = "128000.0f";

        private const string m_adjustedDepth = "48";
        private const string m_adjustedMaxViewRange = "128000.0f";

        private string m_path;
        private XDocument m_file;

        public bool setPathIfValid(string path)
        {
            if (isPathValid(path))
            {
                m_path = path + "/data/ini/ConfigDefault.xml";
                return true;
            }

            return false;
        }

        public void saveConfig()
        {
            m_file.Save(m_path);

            // remove first line that's not in elex config by default
            var file = File.ReadAllLines(m_path).ToList();
            file.RemoveAt(0);

            File.WriteAllLines(m_path, file);
        }


        public void readConfig()
        {
            createBackupIfNeeded();
            m_file = XDocument.Load(m_path, LoadOptions.PreserveWhitespace);
        }

        public void modifyFog(FogType type)
        {
            var test = m_file.Elements("global").Elements("Engine").Elements("Render").Elements("Fog").Elements().First().Name.ToString();
            var depths =
                m_file.Elements("global").Elements("Engine").Elements("Render").Elements("Fog").Elements().ToDictionary
                (
                    c => c.Name,
                    c => c.Attribute("Depth")
                );

            var maxViewRanges =
                m_file.Elements("global").Elements("Engine").Elements("Render").Elements("Fog").Elements().ToDictionary
                (
                    c => c.Name,
                    c => c.Attribute("MaxViewRange")
                );

            switch (type)
            {
                case FogType.Removed:
                    foreach (KeyValuePair<XName, XAttribute> v in depths)
                    {
                        v.Value.SetValue(m_removedDepth);
                    }

                    foreach (KeyValuePair<XName, XAttribute> v in maxViewRanges)
                    {
                        v.Value.SetValue(m_removedMaxViewRange);
                    }
                    break;

                case FogType.Adjusted:
                    foreach (KeyValuePair<XName, XAttribute> v in depths)
                    {
                        v.Value.SetValue(m_adjustedDepth);
                    }

                    foreach (KeyValuePair<XName, XAttribute> v in maxViewRanges)
                    {
                        v.Value.SetValue(m_adjustedMaxViewRange);
                    }
                    break;

                case FogType.Default:
                    depths["Low"].SetValue("96");
                    depths["Medium"].SetValue("128");
                    depths["High"].SetValue("192");
                    depths["Ultra"].SetValue("256");

                    maxViewRanges["Low"].SetValue("4800.0f");
                    maxViewRanges["Medium"].SetValue("4800.0f");
                    maxViewRanges["High"].SetValue("6400.0f");
                    maxViewRanges["Ultra"].SetValue("6400.0f");
                    break;
            }
        }

        private bool isPathValid(string path)
        {
            if (File.Exists(path + "/system/ELEX.exe"))
            {
                return true;
            }

            return false;
        }

        private void createBackupIfNeeded()
        {
            if(!File.Exists(m_path + "_backup"))
            {
                File.Copy(m_path, m_path + "_backup");
            }
        }
    }
}
