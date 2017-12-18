using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Database : MonoBehaviour {

    ArmorDatabase dataArmor;
    EnemyDatabase dataEnemy;
    EssenceDatabase dataEss;
    ItemDatabase dataItem;
    NPCDatabase dataNpc;
    PotionDatabase dataPot;
    ScrollDatabase dataScroll;
    SkillDatabase dataSkill;
    TalismanDatabase dataTali;
    WeaponDatabase dataWep;

    // Use this for initialization
    void Start()
    {
        dataArmor = ArmorDatabase.Load("Armors");
        dataEnemy = EnemyDatabase.Load("Enemies");
        dataEss = EssenceDatabase.Load("Essences");
        dataItem = ItemDatabase.Load("Items");
        dataNpc = NPCDatabase.Load("NPCs");
        dataPot = PotionDatabase.Load("Potions");
        dataScroll = ScrollDatabase.Load("Scrolls");
        dataSkill = SkillDatabase.Load("Skills");
        dataTali = TalismanDatabase.Load("Talismans");
        dataWep = WeaponDatabase.Load("Weapons");

        Debug.Log("Database Loaded");
        foreach (Armor arm in dataArmor.armors)
        {
            arm.found = true;
            if (arm.found)
            {
                Debug.Log("Armor 0" + arm.ID + ":" + arm.Name);
            }
        }
    }

    
}
