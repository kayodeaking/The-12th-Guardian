using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("EssenceDatabase")]
public class EssenceDatabase
{

    [XmlArray("Essences")]
    [XmlArrayItem("Essence")]
    public List<Essence> essences = new List<Essence>();

    public static EssenceDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(EssenceDatabase));
        StringReader reader = new StringReader(_xml.text);
        EssenceDatabase essences = serializer.Deserialize(reader) as EssenceDatabase;
        reader.Close();
        return essences;
    }
}
