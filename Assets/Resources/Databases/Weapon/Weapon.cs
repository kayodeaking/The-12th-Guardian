using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class Weapon : Item {

    public enum Element1
    {
        Fire = 1,
        Ice,
        Lightning,
        Water,
        Earth,
        Wind,
        Holy,
        Dark
    };
    public int element1Amount;
    public enum Element2
    {
        Fire = 1,
        Ice,
        Lightning,
        Water,
        Earth,
        Wind,
        Holy,
        Dark
    };
    public int element2Amount;
    public int LevelRequirement;
    public int Attack;
    public int Defense;
    public int MagicAttack;
    public int MagicDefense;
    public int Body;
    public int Soul;
    public int Agility;
    public int Luck;
    public int Corruption;

}