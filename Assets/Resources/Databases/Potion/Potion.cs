﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Potion : Item {

    
    public enum Effector1
    { 
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    public enum Effector2
    {
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    public enum Effector3
    {
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    public enum Effector4
    {
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    public enum Effector5
    {
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    public enum Effector6
    {
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    public enum Effector7
    {
        [XmlEnum("Health")]
        Health,
        [XmlEnum("Mana")]
        Mana,
        [XmlEnum("Health")]
        Attack,
        [XmlEnum("Health")]
        Defense,
        [XmlEnum("MagicAtt")]
        MagicAtt,
        [XmlEnum("MagicDef")]
        MagicDef,
        [XmlEnum("Agility")]
        Agility,
        [XmlEnum("Luck")]
        Luck,
        [XmlEnum("Poison")]
        Poison,
        [XmlEnum("Blindness")]
        Blindness,
        [XmlEnum("Silence")]
        Silence,
        [XmlEnum("Provoke")]
        Provoke,
        [XmlEnum("Confusion")]
        Confusion,
        [XmlEnum("Fascination")]
        Fascination,
        [XmlEnum("Sleep")]
        Sleep,
        [XmlEnum("Corruption")]
        Corruption
    }
    [XmlElement("Amount")]
    public int Amount;
    [XmlElement("Duration")]
    public int Duration;

}
