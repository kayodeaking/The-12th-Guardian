using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("PotionCollection")]
public class PotionContainer {

	[XmlArray("Potions")]
	[XmlArrayItem("Potion")]
	public List<Potion> potions = new List<Potion>();

	public static PotionContainer Load(string path) {
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(PotionContainer));
		StringReader reader = new StringReader (_xml.text);
		PotionContainer potions = serializer.Deserialize (reader) as PotionContainer;
		reader.Close();
		return potions;
	}

}
