using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("WeaponDatabase")]
public class WeaponDatabase
{

    [XmlArray("Weapons")]
    [XmlArrayItem("Weapon")]
    public List<Weapon> weapons = new List<Weapon>();

    public static WeaponDatabase Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(WeaponDatabase));
        StringReader reader = new StringReader(_xml.text);
        WeaponDatabase items = serializer.Deserialize(reader) as WeaponDatabase;
        reader.Close();
        return items;
    }
}
