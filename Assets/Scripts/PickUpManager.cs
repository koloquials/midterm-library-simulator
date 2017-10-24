using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpManager : MonoBehaviour {

	public GameObject player;
	public GameObject handItem;
	public GameObject thisWorldItem; //visual depiction of item on the world map
	public GameObject newWorldItem; //any drop point that might replace this
	public Text textBox;
	float range;
	public AudioSource flip;

	void Start(){
	}

	void OnMouseOver () {
		range = Vector3.Distance(transform.position, player.transform.position);
		if (range > 8f) {
			if (PlayerInfoManager.hasItem == false) {
//				textBox.text = "not close enough"; 
			}
		} else {
//			textBox.text = "can pick up now :)"; 
			if (Input.GetMouseButton (0) && PlayerInfoManager.hasItem == false){
				flip.Play ();
				handItem.SetActive(true);
				PlayerInfoManager.hasItem = true;
				PlayerInfoManager.heldItem = handItem;
				newWorldItem.gameObject.SetActive (true);
				thisWorldItem.gameObject.SetActive (false);
				this.gameObject.SetActive(false);
			}
		}
	}
}
