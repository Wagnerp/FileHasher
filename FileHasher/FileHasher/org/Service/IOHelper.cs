using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHasher.org.model;
using System.Xml;

namespace FileHasher.org.Service
{
    public static class IOHelper
    {
        public static void SaveHashTable(HashTable hashTable, string pathToSave)
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
    }
}
