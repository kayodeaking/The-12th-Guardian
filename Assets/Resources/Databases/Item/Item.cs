using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Item {

    [XmlAttribute("ID")]
    public int ID;
    [XmlElement("Name")]
    public string Name;
    [XmlElement("Description")]
    public string Description;
    [XmlElement("Price")]
    public int Price;
    public enum Type
    {
        [XmlEnum(Name ="Crafting")]
        Crafting,
        [XmlEnum(Name ="Regular")]
        Regular,
        [XmlEnum(Name ="Special")]
        Special,
        [XmlEnum(Name ="Ammo")]
        Ammo,
        [XmlEnum(Name = "Body")]
        Body,
        [XmlEnum(Name = "Earrings")]
        Earrings,
        [XmlEnum(Name = "Head")]
        Head,
        [XmlEnum(Name = "Necklace")]
        Necklace,
        [XmlEnum(Name = "Ring")]
        Ring,
        [XmlEnum(Name = "Shoes")]
        Shoes,
        Sword,
        Sword2H,
        Axe,
        Claw,
        Dagger,
        Glove,
        Gun,
        Bow,
        Crossbow,
        Wand,
        Staff,
        MediseaSeed,
        Talisman,
        [XmlEnum(Name = "Restorative")]
        Restorative,
        [XmlEnum(Name = "Cure")]
        Cure,
        [XmlEnum(Name = "Buff")]
        Buff,
    };
    [XmlElement("Consumable")]
    public bool Consumable;
    [XmlElement("IngredientsIDs")]
    [XmlElement("IngredientsID")]
    public List<int> IngredientsID = new List<int>();
    [XmlElement("IngredientsAmounts")]
    [XmlElement("IngerdientsAmount")]
    public List<int> IngredientsAmount = new List<int>();
    [XmlElement("IngredientsDataIDs")]
    [XmlElement("IngredientsDataID")]
    public List<string> IngredientsDataID = new List<string>();
    [XmlElement("Found")]
    public bool found;
}
