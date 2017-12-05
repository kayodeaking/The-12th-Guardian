using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("EnemyCollection")]
public class EnemyContainer {

	[XmlArray("Enemies")]
	[XmlArrayItem("Enemy")]
	public List<Enemy> enemies = new List<Enemy>();

	public static EnemyContainer Load(string path) {
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(EnemyContainer));
		StringReader reader = new StringReader (_xml.text);
		EnemyContainer enemies = serializer.Deserialize (reader) as EnemyContainer;
		reader.Close();
		return enemies;
	}
}
