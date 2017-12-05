using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("WeaponCollection")]
public class WeaponContainer {

	[XmlArray("Weapons")]
	[XmlArrayItem("Weapon")]
	public List<Weapon> weapons = new List<Weapon>();

	public static WeaponContainer Load(string path) {
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(WeaponContainer));
		StringReader reader = new StringReader (_xml.text);
		WeaponContainer items = serializer.Deserialize (reader) as WeaponContainer;
		reader.Close();
		return items;
	}
}
