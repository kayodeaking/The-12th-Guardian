using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Enemy {

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
        [XmlEnum(Name ="Augmentation")]
        Augmentation
    }
    public enum Effector1
    {
        [XmlEnum(Name ="Health")]
        Health,
        [XmlEnum(Name ="Mana")]
        Mana,
        [XmlEnum(Name ="Attack")]
        Attack,
        [XmlEnum(Name ="Defense")]
        Defense,
        [XmlEnum(Name ="MagicAtt")]
        MagicAtt,
        [XmlEnum(Name ="MagicDef")]
        MagicDef,
        [XmlEnum(Name ="Agility")]
        Agility,
        [XmlEnum(Name ="Luck")]
        Luck,
        [XmlEnum(Name ="Poison")]
        Poison,
        [XmlEnum(Name ="Blindness")]
        Blindness,
        [XmlEnum(Name ="Silence")]
        Silence,
        [XmlEnum(Name ="Provoke")]
        Provoke,
        [XmlEnum(Name ="Confusion")]
        Confusion,
        [XmlEnum(Name ="Fascination")]
        Fascination,
        [XmlEnum(Name ="Sleep")]
        Sleep,
        [XmlEnum(Name ="Corruption")]
        Corruption,
        [XmlEnum(Name ="Fire")]
        Fire,
        [XmlEnum(Name ="Ice")]
        Ice,
        [XmlEnum(Name ="Lightning")]
        Lightning,
        [XmlEnum(Name ="Water")]
        Water,
        [XmlEnum(Name ="Earth")]
        Earth,
        [XmlEnum(Name ="Wind")]
        Wind,
        [XmlEnum(Name ="Holy")]
        Holy,
        [XmlEnum(Name ="Dark")]
        Dark,
        [XmlEnum(Name ="Exp")]
        Exp
    }
    public enum Effector2
    {
        [XmlEnum(Name = "Health")]
        Health,
        [XmlEnum(Name = "Mana")]
        Mana,
        [XmlEnum(Name = "Attack")]
        Attack,
        [XmlEnum(Name = "Defense")]
        Defense,
        [XmlEnum(Name = "MagicAtt")]
        MagicAtt,
        [XmlEnum(Name = "MagicDef")]
        MagicDef,
        [XmlEnum(Name = "Agility")]
        Agility,
        [XmlEnum(Name = "Luck")]
        Luck,
        [XmlEnum(Name = "Poison")]
        Poison,
        [XmlEnum(Name = "Blindness")]
        Blindness,
        [XmlEnum(Name = "Silence")]
        Silence,
        [XmlEnum(Name = "Provoke")]
        Provoke,
        [XmlEnum(Name = "Confusion")]
        Confusion,
        [XmlEnum(Name = "Fascination")]
        Fascination,
        [XmlEnum(Name = "Sleep")]
        Sleep,
        [XmlEnum(Name = "Corruption")]
        Corruption,
        [XmlEnum(Name = "Fire")]
        Fire,
        [XmlEnum(Name = "Ice")]
        Ice,
        [XmlEnum(Name = "Lightning")]
        Lightning,
        [XmlEnum(Name = "Water")]
        Water,
        [XmlEnum(Name = "Earth")]
        Earth,
        [XmlEnum(Name = "Wind")]
        Wind,
        [XmlEnum(Name = "Holy")]
        Holy,
        [XmlEnum(Name = "Dark")]
        Dark,
        [XmlEnum(Name = "Exp")]
        Exp
    }
    public enum Effector3
    {
        [XmlEnum(Name = "Health")]
        Health,
        [XmlEnum(Name = "Mana")]
        Mana,
        [XmlEnum(Name = "Attack")]
        Attack,
        [XmlEnum(Name = "Defense")]
        Defense,
        [XmlEnum(Name = "MagicAtt")]
        MagicAtt,
        [XmlEnum(Name = "MagicDef")]
        MagicDef,
        [XmlEnum(Name = "Agility")]
        Agility,
        [XmlEnum(Name = "Luck")]
        Luck,
        [XmlEnum(Name = "Poison")]
        Poison,
        [XmlEnum(Name = "Blindness")]
        Blindness,
        [XmlEnum(Name = "Silence")]
        Silence,
        [XmlEnum(Name = "Provoke")]
        Provoke,
        [XmlEnum(Name = "Confusion")]
        Confusion,
        [XmlEnum(Name = "Fascination")]
        Fascination,
        [XmlEnum(Name = "Sleep")]
        Sleep,
        [XmlEnum(Name = "Corruption")]
        Corruption,
        [XmlEnum(Name = "Fire")]
        Fire,
        [XmlEnum(Name = "Ice")]
        Ice,
        [XmlEnum(Name = "Lightning")]
        Lightning,
        [XmlEnum(Name = "Water")]
        Water,
        [XmlEnum(Name = "Earth")]
        Earth,
        [XmlEnum(Name = "Wind")]
        Wind,
        [XmlEnum(Name = "Holy")]
        Holy,
        [XmlEnum(Name = "Dark")]
        Dark,
        [XmlEnum(Name = "Exp")]
        Exp
    }
    public enum Effector4
    {
        [XmlEnum(Name = "Health")]
        Health,
        [XmlEnum(Name = "Mana")]
        Mana,
        [XmlEnum(Name = "Attack")]
        Attack,
        [XmlEnum(Name = "Defense")]
        Defense,
        [XmlEnum(Name = "MagicAtt")]
        MagicAtt,
        [XmlEnum(Name = "MagicDef")]
        MagicDef,
        [XmlEnum(Name = "Agility")]
        Agility,
        [XmlEnum(Name = "Luck")]
        Luck,
        [XmlEnum(Name = "Poison")]
        Poison,
        [XmlEnum(Name = "Blindness")]
        Blindness,
        [XmlEnum(Name = "Silence")]
        Silence,
        [XmlEnum(Name = "Provoke")]
        Provoke,
        [XmlEnum(Name = "Confusion")]
        Confusion,
        [XmlEnum(Name = "Fascination")]
        Fascination,
        [XmlEnum(Name = "Sleep")]
        Sleep,
        [XmlEnum(Name = "Corruption")]
        Corruption,
        [XmlEnum(Name = "Fire")]
        Fire,
        [XmlEnum(Name = "Ice")]
        Ice,
        [XmlEnum(Name = "Lightning")]
        Lightning,
        [XmlEnum(Name = "Water")]
        Water,
        [XmlEnum(Name = "Earth")]
        Earth,
        [XmlEnum(Name = "Wind")]
        Wind,
        [XmlEnum(Name = "Holy")]
        Holy,
        [XmlEnum(Name = "Dark")]
        Dark,
        [XmlEnum(Name = "Exp")]
        Exp
    }
    public enum Effector5
    {
        [XmlEnum(Name = "Health")]
        Health,
        [XmlEnum(Name = "Mana")]
        Mana,
        [XmlEnum(Name = "Attack")]
        Attack,
        [XmlEnum(Name = "Defense")]
        Defense,
        [XmlEnum(Name = "MagicAtt")]
        MagicAtt,
        [XmlEnum(Name = "MagicDef")]
        MagicDef,
        [XmlEnum(Name = "Agility")]
        Agility,
        [XmlEnum(Name = "Luck")]
        Luck,
        [XmlEnum(Name = "Poison")]
        Poison,
        [XmlEnum(Name = "Blindness")]
        Blindness,
        [XmlEnum(Name = "Silence")]
        Silence,
        [XmlEnum(Name = "Provoke")]
        Provoke,
        [XmlEnum(Name = "Confusion")]
        Confusion,
        [XmlEnum(Name = "Fascination")]
        Fascination,
        [XmlEnum(Name = "Sleep")]
        Sleep,
        [XmlEnum(Name = "Corruption")]
        Corruption,
        [XmlEnum(Name = "Fire")]
        Fire,
        [XmlEnum(Name = "Ice")]
        Ice,
        [XmlEnum(Name = "Lightning")]
        Lightning,
        [XmlEnum(Name = "Water")]
        Water,
        [XmlEnum(Name = "Earth")]
        Earth,
        [XmlEnum(Name = "Wind")]
        Wind,
        [XmlEnum(Name = "Holy")]
        Holy,
        [XmlEnum(Name = "Dark")]
        Dark,
        [XmlEnum(Name = "Exp")]
        Exp
    }
    [XmlElement("Amount")]
    public int Amount;
    [XmlElement("Consumable")]
    public bool Consumable;
    [XmlArray("IngredientsIDs")]
    [XmlArrayItem("IngredientsID")]
    public List<int> IngredientsID = new List<int>();
    [XmlArray("IngredientsAmounts")]
    [XmlArrayItem("IngredientsAmount")]
    public List<int> IngredientsAmount = new List<int>();
    [XmlElement("IngredientsDataIDs")]
    [XmlElement("IngredientsDataID")]
    public List<int> IngredientsDataID = new List<int>();

}
