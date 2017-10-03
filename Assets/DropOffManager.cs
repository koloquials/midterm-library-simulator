using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOffManager : MonoBehaviour {
	
	public GameObject player;
	public GameObject worldItem;
	public Text textBox;
	float range;

	void Update () {
		range = Vector3.Distance(transform.position, player.transform.position);
		if (range > 8f) {
			if (PlayerInfoManager.hasItem == true) {
				textBox.text = "[hi]"; 
			} 
		} else {
			textBox.text = "[HELLO]"; 
			if (Input.GetKeyDown(KeyCode.Space) && PlayerInfoManager.hasItem == true){
				PlayerInfoManager.heldItem.SetActive(false);
				PlayerInfoManager.hasItem = false;
				PlayerInfoManager.heldItem = null;
				worldItem.gameObject.SetActive(true);
			}
		}
	}
}
