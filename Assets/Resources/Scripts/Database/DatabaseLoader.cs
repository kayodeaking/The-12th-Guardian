using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseLoader : MonoBehaviour {

	ItemContainer ic;
	PotionContainer pc;
	EssenceContainer ec;
	WeaponContainer wc;
	ArmorContainer ac;
	NPCContainer npcc;
	EnemyContainer enc;

	// Use this for initialization
	void Start () {
		ic = ItemContainer.Load ("Items");
		pc = PotionContainer.Load ("Potions");
		ec = EssenceContainer.Load ("Essences");
		wc = WeaponContainer.Load ("Weapons");
		ac = ArmorContainer.Load ("Armors");
		npcc = NPCContainer.Load ("NPCs");
		enc = EnemyContainer.Load ("Enemies");
	}

	public void BookofItems() {
		foreach (Item item in ic.items) {
			item.found = true;
			if (item.found) {
				Debug.Log ("Item 0" + item.id + ": " + item.name + ", " + item.price + "G, Type: " + item.type
					+ ", Consumable: " + item.consumable + ", Soul Ingredients: " + item.ingridents +", Description: " 
					+ item.description + ", Found: " + item.found);
			} else {
				Debug.Log ("Item 0" + item.id + " has still not been found");
			}
		}
		foreach (Potion pot in pc.potions) {
			pot.found = true;
			if (pot.found) {
				Debug.Log ("Potion 0" + pot.id + ": " + pot.name + ", " + pot.price + "G, Type: " + pot.type
					+ ", Consumable: " + pot.consumable + ", Soul Ingredients: " + pot.ingridents +", Description: " 
					+ pot.description + ", Effector: [" + pot.effector + ": " + pot.amount + ", Duration: " 
					+ pot.duration + ", Found: " + pot.found);
			} else {
				Debug.Log ("Potion 0" + pot.id + " has still not been found");
			}
		}
		foreach (Essence ess in ec.essences) {
			ess.found = true;
			if (ess.found) {
				Debug.Log ("Essence 0" + ess.id + ": " + ess.name + ", " + ess.price + "G, Type: " + ess.type
					+ ", Consumable: " + ess.consumable + ", Soul Ingredients: " + ess.ingridents +", Description: " 
					+ ess.description +  ", Effector: [" + ess.effector + ": " + ess.amount + ", Found: " + ess.found);
			} else {
				Debug.Log ("Essence 0" + ess.id + " has still not been found");
			}
		}
		foreach (Weapon wep in wc.weapons) {
			wep.found = true;
			if (wep.found) {
				Debug.Log ("Weapon 0" + wep.id + ": " + wep.name + ",Attack: " + wep.att + " ,Defense: " + wep.def + 
					", Magic Attack: " + wep.mAtt + ", Magic Defense: " + wep.mDef + ", Agility: " + wep.agi + ", Luck: " 
					+ wep.luk+ ", Body: " + wep.hp + ", Soul: "+ wep.mp + ", Soul Slots: " + wep.slots + ", " + wep.price 
					+ "G, Type: " + wep.type + ", Consumable: " + wep.consumable +  ", Soul Ingredients: " + wep.ingridents 
					+ ", Description: " + wep.description + ", Level Requierment: " + wep.lvReq + ", Found: " + wep.found);
			} else {
				Debug.Log ("Weapon 0" + wep.id + " has still not been found");
			}
		}
		foreach (Armor arm in ac.armors) {
			arm.found = true;
			if (arm.found) {
				Debug.Log ("Armor 0" + arm.id + ": " + arm.name + ",Attack: " + arm.att + " ,Defense: " + arm.def + 
					", Magic Attack: " + arm.mAtt + ", Magic Defense: " + arm.mDef + ", Agility: " + arm.agi + ", Luck: " 
					+ arm.luk+ ", Body: " + arm.hp + ", Soul: "+ arm.mp + ", Soul Slots: " + arm.slots + ", " + arm.price 
					+ "G, Type: " + arm.type + ", Consumable: " + arm.consumable +  ", Soul Ingredients: " + arm.ingridents 
					+ ", Description: " + arm.description + ", Level Requierment: " + arm.lvReq + ", Found: " + arm.found);
			} else {
				Debug.Log ("Weapon 0" + arm.id + " has still not been found");
			}
		}
	}

	public void BookofSouls() {
		foreach (NPC npc in npcc.nonPlayable) {
			npc.found = true;
			if (npc.found) {
				Debug.Log ("Character 0" + npc.id + ": " + npc.name);
			} else {
				Debug.Log ("Character 0" + npc.id + " has still not been found");
			}
		}
	}

	public void BookofTheWild() {
		foreach (Enemy enemy in enc.enemies) {
			enemy.found = true;
			if (enemy.found) {
				Debug.Log ("Enemies 0" + enemy.id + ": " + enemy.name);
			} else {
				Debug.Log ("Enemies 0" + enemy.id + " has still not been found");
			}
		}
	}
}

