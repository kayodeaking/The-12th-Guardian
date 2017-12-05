using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Item {

	[XmlAttribute("id")]
	public int id;
	[XmlElement("Name")]
	public string name;
	[XmlElement("Description")]
	public string description;
	[XmlElement("Price")]
	public double price;
	[XmlElement("Type")]
	public string type;
	[XmlElement("Consumable")]
	public bool consumable;
	[XmlElement("Found")]
	public bool found;
	[XmlElement("SoulIngredients")]
	public string ingridents;
}
