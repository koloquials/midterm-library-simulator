using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoManager : MonoBehaviour {
	public static bool hasItem = false;
	public static GameObject heldItem = null;
	public static int booksCollected = 0;
	public Text textBox;

	void Update () {
		if (booksCollected >= 3) {
			textBox.text = "MISSION SUCCESS: you found all the books! your time as a faithful city librarian has paid off."; 
		}
	}
}
