using UnityEngine;
using System.Collections;

public class deadGuyScript : MonoBehaviour {

	//public GameObject textBox;
	public GvrFPS textBox;

	// Use this for initialization
	void Start () {
		textBox.showText ("Hi! I'm some text initalized at start");
	}

	public void isPointedAt() {

		textBox.showText ("Hi! I'm some text. a box was pointed at");
	}

	public void notPointedAt() {

		textBox.showText ("");
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
}
