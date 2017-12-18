using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Scroll : Item {

    public enum Rank
    {
        [XmlEnum(Name="Body")]
        Body,
        [XmlEnum(Name="Earrings")]
        Earrings,
        [XmlEnum(Name="Head")]
        Head,
        [XmlEnum(Name="Necklace")]
        Necklace,
        [XmlEnum(Name="Ring")]
        Ring,
        [XmlEnum(Name="Shoes")]
        Shoes
    };
    [XmlElement("LevelRequirement")]
    public int LevelRequirement;
    [XmlElement("Attack")]
    public int Attack;
    [XmlElement("Defense")]
    public int Defense;
    [XmlElement("MagicAttack")]
    public int MagicAttack;
    [XmlElement("MagicDefense")]
    public int MagicDefense;
    [XmlElement("Agility")]
    public int Agility;
    [XmlElement("Luck")]
    public int Luck;
    [XmlElement("Corruption")]
    public int Corruption;
    [XmlElement("Body")]
    public int Body;
    [XmlElement("Soul")]
    public int Soul;
    [XmlArray("SoulSlots")]
    [XmlArrayItem("SoulSlot")]
    public List<int> SoulSlots = new List<int>();

}
