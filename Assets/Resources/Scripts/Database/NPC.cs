using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class NPC : Character {

	[XmlElement("DialogueFile")]
	public string dialogueFile;
	[XmlElement("Playermode")]
	public bool playerMode;
}
