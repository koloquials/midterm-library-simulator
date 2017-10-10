using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpManager : MonoBehaviour {

	public GameObject player;
	public GameObject handItem;
	public GameObject worldItem;
	public Text textBox;
	float range;

	void OnMouseOver () {
		range = Vector3.Distance(transform.position, player.transform.position);
		if (range > 8f) {
			if (PlayerInfoManager.hasItem == false) {
				textBox.text = "not close enough"; 
			}
		} else {
			textBox.text = "can pick up now :)"; 
			if (Input.GetKeyDown(KeyCode.Space) && PlayerInfoManager.hasItem == false){
				handItem.SetActive(true);
				PlayerInfoManager.hasItem = true;
				PlayerInfoManager.heldItem = handItem;
				worldItem.gameObject.SetActive (true);
				this.gameObject.SetActive(false);
			}
		}
	}
}
