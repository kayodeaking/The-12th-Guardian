using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("TalismanDatabase")]
public class TalismanDatabase
{

    [XmlArray("Talismans")]
    [XmlArrayItem("Talisman")]
    public List<Talisman> talismans = new List<Talisman>();

    public static TalismanDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(TalismanDatabase));
        StringReader reader = new StringReader(_xml.text);
        TalismanDatabase items = serializer.Deserialize(reader) as TalismanDatabase;
        reader.Close();
        return items;
    }
}
