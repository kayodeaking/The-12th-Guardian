﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Essence : Item {

	[XmlElement("Effector")]
	public string effector;
	[XmlElement("Amount")]
	public int amount;
}
