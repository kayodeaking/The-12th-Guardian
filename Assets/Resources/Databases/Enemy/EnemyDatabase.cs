using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("EnemyDatabase")]
public class EnemyDatabase
{

    [XmlArray("Enemies")]
    [XmlArrayItem("Enemy")]
    public List<Enemy> enemies = new List<Enemy>();

    public static EnemyDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(EnemyDatabase));
        StringReader reader = new StringReader(_xml.text);
        EnemyDatabase essences = serializer.Deserialize(reader) as EnemyDatabase;
        reader.Close();
        return essences;
    }
}
