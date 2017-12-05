using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("EssenceCollection")]
public class EssenceContainer {

	[XmlArray("Essences")]
	[XmlArrayItem("Essence")]
	public List<Essence> essences = new List<Essence>();

	public static EssenceContainer Load(string path) {
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(EssenceContainer));
		StringReader reader = new StringReader (_xml.text);
		EssenceContainer essences = serializer.Deserialize (reader) as EssenceContainer;
		reader.Close();
		return essences;
	}
}
