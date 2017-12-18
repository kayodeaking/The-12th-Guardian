using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("PotionDatabase")]
public class PotionDatabase
{

    [XmlArray("Potions")]
    [XmlArrayItem("Potion")]
    public List<Potion> potions = new List<Potion>();

    public static PotionDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(PotionDatabase));
        StringReader reader = new StringReader(_xml.text);
        PotionDatabase potions = serializer.Deserialize(reader) as PotionDatabase;
        reader.Close();
        return potions;
    }

}
