using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("ScrollDatabase")]
public class ScrollDatabase
{

    [XmlArray("Scrolls")]
    [XmlArrayItem("Scroll")]
    public List<Scroll> scrolls = new List<Scroll>();

    public static ScrollDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ScrollDatabase));
        StringReader reader = new StringReader(_xml.text);
        ScrollDatabase potions = serializer.Deserialize(reader) as ScrollDatabase;
        reader.Close();
        return potions;
    }

}
