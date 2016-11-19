using UnityEngine;
using System.Collections;

public class GenerateBodyScript : MonoBehaviour {

	public GameObject personPrefab;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject person = Instantiate (personPrefab);
			GUIText text = person.GetComponent<GUIText> ();
			text.text = "space";
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject person = Instantiate (personPrefab);
			GUIText text = person.GetComponent<GUIText> ();
			text.text = "right";
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject person = Instantiate (personPrefab);
			GUIText text = person.GetComponent<GUIText> ();
			text.text = "left";
		}
	}
}
