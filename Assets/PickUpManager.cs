using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpManager : MonoBehaviour {

	public GameObject player;
	public GameObject handItem;
	public Text textBox;
	float range;

	void Update () {
		range = Vector3.Distance(transform.position, player.transform.position);
		if (range > 8f) {
			if (PlayerInfoManager.hasItem == false) {
				textBox.text = "[NO]"; 
			}
		} else {
			textBox.text = "[yes]"; 
			if (Input.GetKeyDown(KeyCode.Space) && PlayerInfoManager.hasItem == false){
				handItem.SetActive(true);
				PlayerInfoManager.hasItem = true;
				PlayerInfoManager.heldItem = handItem;
				this.gameObject.SetActive(false);
			}
		}
	}
}
