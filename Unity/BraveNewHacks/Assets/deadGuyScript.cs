using UnityEngine;
using System.Collections;

public class deadGuyScript : MonoBehaviour {

	public GameObject textBox;

	// Use this for initialization
	void Start () {
		textBox.showText ("Hi! I'm some text initalized at start");
	}

	public void isPointedAt() {

		textBox.showText ("Hi! I'm some text.");
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
}
