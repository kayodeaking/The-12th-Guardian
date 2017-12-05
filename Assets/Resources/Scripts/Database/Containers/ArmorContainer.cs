using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("ArmorCollection")]
public class ArmorContainer {

	[XmlArray("Armors")]
	[XmlArrayItem("Armor")]
	public List<Armor> armors = new List<Armor>();

	public static ArmorContainer Load(string path) {
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(ArmorContainer));
		StringReader reader = new StringReader (_xml.text);
		ArmorContainer armors = serializer.Deserialize (reader) as ArmorContainer;
		reader.Close();
		return armors;
	}
}
