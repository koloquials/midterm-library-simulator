using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoManager : MonoBehaviour {
	public static bool gameStarted = false;
	static bool spacePressed = false;
	public static bool hasItem = false;
	public static GameObject heldItem = null;
	public static int booksCollected = 0;
	public Text textBox;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && gameStarted == false){
			textBox.text = "\n\n\n\n\n\n\n[excellent. please click to begin.]";
			spacePressed = true;
		}
		if (spacePressed == true && Input.GetMouseButton(0)) {
			gameStarted = true;
			textBox.text = "";
		}
		if (booksCollected >= 3) {
			textBox.text = "MISSION SUCCESS: you found all the books! your time as a faithful city librarian has paid off.\n(you can find the rest if you want, but your soul is free)"; 
		}
	}
}
