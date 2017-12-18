using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Skill {

    [XmlAttribute("ID")]
    public int ID;
    [XmlElement("Name")]
    public string Name;
    [XmlElement("Description")]
    public string Description;
    public enum Class
    {
        [XmlEnum(Name ="Novice")]
        Novice,
        [XmlEnum(Name ="Fighter")]
        Fighter,
        [XmlEnum(Name ="Auxiliary")]
        Auxiliary,
        [XmlEnum(Name ="Punk")]
        Punk,
        [XmlEnum(Name ="Caster")]
        Caster,
        [XmlEnum(Name ="Guard")]
        Guard,
        [XmlEnum(Name ="Archer")]
        Archer,
        [XmlEnum(Name ="Thief")]
        Thief,
        [XmlEnum(Name ="Magician")]
        Magician,
        [XmlEnum(Name ="Blader")]
        Blader,
        [XmlEnum(Name ="Knight")]
        Knight,
        [XmlEnum(Name ="Shooter")]
        Shooter,
        [XmlEnum(Name ="Crossbowman")]
        Crossbowman,
        [XmlEnum(Name ="Bowman")]
        Bowman,
        [XmlEnum(Name ="Mercenary")]
        Mercenary,
        [XmlEnum(Name ="MartialArtist")]
        MartialArtist,
        [XmlEnum(Name ="Ninja")]
        Ninja,
        [XmlEnum(Name ="Wizard")]
        Wizard,
        [XmlEnum(Name ="Cleric")]
        Cleric,
        [XmlEnum(Name ="DarkCleric")]
        DarkCleric,
        [XmlEnum(Name ="DualBlader")]
        DualBlader,
        [XmlEnum(Name ="HolyKnight")]
        HolyKnight,
        [XmlEnum(Name ="DarkKnight")]
        DarkKnight,
        [XmlEnum(Name ="Gunner")]
        Gunner,
        [XmlEnum(Name ="Marksman")]
        Marksman,
        [XmlEnum(Name ="Hawkeye")]
        Hawkeye,
        [XmlEnum(Name ="Assassin")]
        Assassin,
        [XmlEnum(Name ="Sensi")]
        Sensi,
        [XmlEnum(Name ="Shinobi")]
        Shinobi,
        [XmlEnum(Name ="Druid")]
        Druid,
        [XmlEnum(Name ="Bishop")]
        Bishop,
        [XmlEnum(Name ="DarkBishop")]
        DarkBishop,
        [XmlEnum(Name ="Executioner")]
        Executioner,
        [XmlEnum(Name ="Crusader")]
        Crusader,
        [XmlEnum(Name ="Destroyer")]
        Destroyer,
        [XmlEnum(Name ="Gunsmith")]
        Gunsmith,
        [XmlEnum(Name ="GroundHawk")]
        GroundHawk,
        [XmlEnum(Name ="SkyHawk")]
        SkyHawk,
        [XmlEnum(Name ="ShadowLord")]
        ShadowLord,
        [XmlEnum(Name ="DragonLord")]
        DragonLord,
        [XmlEnum(Name ="NightLord")]
        NightLord,
        [XmlEnum(Name ="ArchMageNature")]
        ArchMageNature,
        [XmlEnum(Name ="ArchMageLight")]
        ArchMageLight,
        [XmlEnum(Name ="ArchMageVoid")]
        ArchMageVoid
    };
    [XmlElement("LevelRequirement")]
    public int LevelRequirement;
    public enum Type
    {
        [XmlEnum(Name ="attack")]
        Attack,
        [XmlEnum(Name ="Guard")]
        Guard,
        [XmlEnum(Name ="state")]
        State,
        [XmlEnum(Name ="Effect")]
        Effect,
        [XmlEnum(Name ="Skill")]
        Skill
    };
    [XmlElement("Damage")]
    public int Damage;
    [XmlElement("MPCost")]
    public int MPCost;
    [XmlElement("HPCost")]
    public int HPCost;
    public enum Occasion
    {
        [XmlEnum(Name ="Ground")]
        Ground,
        [XmlEnum(Name ="Air")]
        Air,
        [XmlEnum(Name ="Water")]
        Water,
    };
    [XmlElement("Scope")]
    public int Scope;
    public enum HitType
    {
        [XmlEnum(Name ="None")]
        None,
        [XmlEnum(Name ="Physical")]
        Physical,
        [XmlEnum(Name ="Range")]
        Range,
        [XmlEnum(Name ="Magic")]
        Magic
    };
    public enum GainType
    {
        [XmlEnum(Name ="None")]
        None,
        [XmlEnum(Name ="Body")]
        Body,
        [XmlEnum(Name ="Soul")]
        Soul,
        [XmlEnum(Name ="Corruption")]
        Corruption
    };
    [XmlElement("GainAmount")]
    public int GainAmount;
    [XmlElement("Speed")]
    public int Speed;
    public enum WepReq1
    {
        [XmlEnum(Name ="None")]
        None,
        [XmlEnum(Name ="Sword")]
        Sword,
        [XmlEnum(Name ="Sword2H")]
        Sword2H,
        [XmlEnum(Name ="Axe")]
        Axe,
        [XmlEnum(Name ="Claw")]
        Claw,
        [XmlEnum(Name ="Dagger")]
        Dagger,
        [XmlEnum(Name ="Glove")]
        Glove,
        [XmlEnum(Name ="Gun")]
        Gun,
        [XmlEnum(Name ="Bow")]
        Bow,
        [XmlEnum(Name ="Crossbow")]
        Crossbow,
        [XmlEnum(Name ="Wand")]
        Wand,
        [XmlEnum(Name ="Staff")]
        Staff,
        [XmlEnum(Name ="MediseaSeed")]
        MediseaSeed
    };
    public enum WepReq2
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Sword")]
        Sword,
        [XmlEnum(Name = "Sword2H")]
        Sword2H,
        [XmlEnum(Name = "Axe")]
        Axe,
        [XmlEnum(Name = "Claw")]
        Claw,
        [XmlEnum(Name = "Dagger")]
        Dagger,
        [XmlEnum(Name = "Glove")]
        Glove,
        [XmlEnum(Name = "Gun")]
        Gun,
        [XmlEnum(Name = "Bow")]
        Bow,
        [XmlEnum(Name = "Crossbow")]
        Crossbow,
        [XmlEnum(Name = "Wand")]
        Wand,
        [XmlEnum(Name = "Staff")]
        Staff,
        [XmlEnum(Name = "MediseaSeed")]
        MediseaSeed
    };
    [XmlElement("Cooldown")]
    public int Cooldown;
    public enum Costs
    {
        [XmlEnum(Name ="None")]
        None,
        [XmlEnum(Name ="Health")]
        Health,
        [XmlEnum(Name ="Mana")]
        Mana,
        [XmlEnum(Name ="Stamina")]
        Stamina
    };
    [XmlElement("SkillReqIDs")]
    [XmlElement("SkillReqID")]
    public List<int> SkillReqID;
    
}
