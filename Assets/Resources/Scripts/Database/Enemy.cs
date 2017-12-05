using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;


public class Enemy : Character {
	[XmlElement("ItemDropList")]
	public string itemDropList;
}
