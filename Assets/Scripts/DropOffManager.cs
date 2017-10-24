using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOffManager : MonoBehaviour {
	
	public GameObject player;
	public GameObject requiredItem;
	public GameObject thisWorldItem; //for visuals that must be turned on
	public GameObject newWorldItem; //for interactables that must be turned on
	public Text textBox;
	public bool isQuestObj = false;
	float range;

	void OnMouseOver () {
		range = Vector3.Distance(transform.position, player.transform.position);
		if (range > 8f) {
			if (PlayerInfoManager.hasItem == true) {
				//textBox.text = "not close enough!!"; 
			} 
		} else {
			//textBox.text = "place thing here! as long as it's the right thing!!!"; 
			if (Input.GetMouseButton (0) && PlayerInfoManager.hasItem == true){
				if (PlayerInfoManager.heldItem != requiredItem) {
					//textBox.text = "WRONG THING!";
				} else {
					if (isQuestObj == true) {
						PlayerInfoManager.booksCollected++;
					}
					PlayerInfoManager.heldItem.SetActive (false);
					PlayerInfoManager.hasItem = false;
					PlayerInfoManager.heldItem = null;
					newWorldItem.gameObject.SetActive (true);
					thisWorldItem.gameObject.SetActive (true);
					gameObject.SetActive (false);
				}
			}
		}
	}
}
