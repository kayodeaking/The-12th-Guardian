using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("SkillDatabase")]
public class SkillDatabase
{

    [XmlArray("Skills")]
    [XmlArrayItem("Skill")]
    public List<Skill> skills = new List<Skill>();

    public static SkillDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(SkillDatabase));
        StringReader reader = new StringReader(_xml.text);
        SkillDatabase items = serializer.Deserialize(reader) as SkillDatabase;
        reader.Close();
        return items;
    }
}
