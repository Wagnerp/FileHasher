using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHasher.org.model;
using System.Xml;
using System.IO;

namespace FileHasher.org.Service
{
    public static class IOHelper
    {
        public static void SaveHashTableAsXml(HashTable hashTable, string pathToSave)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            wSettings.Indent = true;
            wSettings.IndentChars = ("   ");
            XmlWriter xWriter = XmlWriter.Create(pathToSave + @"\hashtable.xml", wSettings);
            xWriter.WriteStartElement("hashtable");

            foreach (PathAndMD5 info in hashTable.FilePathAndHash)
            {
                xWriter.WriteStartElement("file");
                xWriter.WriteAttributeString("path", info.File);
                xWriter.WriteAttributeString("hash", info.MD5);
                xWriter.WriteEndElement();
            }

            xWriter.WriteEndElement();
            xWriter.Flush();
            xWriter.Close();
        }

        public static void SaveHashTableAsTxt(HashTable hashTable, string pathToSave, string format)
        {
            using (FileStream fs = new FileStream(Path.Combine(pathToSave, "hashtable.txt"), FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (PathAndMD5 info in hashTable.FilePathAndHash)
                    {
                        sw.WriteLine(string.Format(format, info.File, info.MD5));                        
                    }
                }
            }
        }
    }
}
