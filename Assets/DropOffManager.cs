using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOffManager : MonoBehaviour {
	
	public GameObject player;
	public GameObject requiredItem;
	public GameObject worldItem;
	public Text textBox;
	public bool isQuestObj = false;
	float range;

	void OnMouseOver () {
		range = Vector3.Distance(transform.position, player.transform.position);
		if (range > 8f) {
			if (PlayerInfoManager.hasItem == true) {
				textBox.text = "not close enough"; 
			} 
		} else {
			textBox.text = "place thing here! as long as it's the right thing!!!"; 
			if (Input.GetKeyDown(KeyCode.Space) && PlayerInfoManager.hasItem == true){
				if (PlayerInfoManager.heldItem != requiredItem) {
					textBox.text = "WRONG THING!";
				} else {
					if (isQuestObj == true) {
						PlayerInfoManager.booksCollected++;
					}
					PlayerInfoManager.heldItem.SetActive (false);
					PlayerInfoManager.hasItem = false;
					PlayerInfoManager.heldItem = null;
					worldItem.gameObject.SetActive (true);
					gameObject.SetActive (false);
				}
			}
		}
	}
}
