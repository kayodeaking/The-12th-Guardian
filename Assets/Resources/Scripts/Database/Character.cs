using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Character {

	[XmlAttribute("id")]
	public int id;
	[XmlElement("Name")]
	public string name;
	[XmlElement("Nickname")]
	public string nickName;
	[XmlElement("Description")]
	public string description;
	[XmlElement("Type")]
	public string type;
	[XmlElement("Age")]
	public int age;
	[XmlElement("Gender")]
	public int gender;
	[XmlElement("Race")]
	public int race;
	[XmlElement("SkinColor")]
	public int skinColor;
	[XmlElement("HairColor")]
	public int hairColor;
	[XmlElement("SkillList")]
	public string skillList;
	[XmlElement("Class")]
	public string myClass;
	[XmlElement("Level")]
	public int level;
	[XmlElement("Body")]
	public double body;
	[XmlElement("Soul")]
	public double soul;
	[XmlElement("Attack")]
	public int att;
	[XmlElement("Defense")]
	public int def;
	[XmlElement("MagicAttack")]
	public int mAtt;
	[XmlElement("MagicDefense")]
	public int mDef;
	[XmlElement("Agility")]
	public int agi;
	[XmlElement("Luck")]
	public int luk;
	[XmlElement("Walking")]
	public bool walking;
	[XmlElement("Found")]
	public bool found;
}
