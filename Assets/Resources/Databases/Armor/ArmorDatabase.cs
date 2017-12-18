using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("ArmorDatabase")]
public class ArmorDatabase
{

    [XmlArray("Armors")]
    [XmlArrayItem("Armor")]
    public List<Armor> armors = new List<Armor>();

    public static ArmorDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ArmorDatabase));
        StringReader reader = new StringReader(_xml.text);
        ArmorDatabase armors = serializer.Deserialize(reader) as ArmorDatabase;
        reader.Close();
        return armors;
    }
}