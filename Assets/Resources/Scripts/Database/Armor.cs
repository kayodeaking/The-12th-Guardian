using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Armor : Item {

	[XmlElement("ArmorType")]
	public string armorType;
	[XmlElement("EquipType")]
	public string eqpType;
	[XmlElement("LevelReq")]
	public int lvReq;
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
	[XmlElement("Body")]
	public int hp;
	[XmlElement("Soul")]
	public int mp;
	[XmlElement("SoulSlots")]
	public int slots;
}
