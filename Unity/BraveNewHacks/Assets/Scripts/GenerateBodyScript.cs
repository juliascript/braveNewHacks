using UnityEngine;
using System.Collections;

public class GenerateBodyScript : MonoBehaviour {

	public GameObject personPrefab;
	public GameObject invisibleCube;

	// Use this for initialization
	void Start () {

		string[] array = {"Brown died of multiple gunshot wounds. His death was ruled a homicide, the coroner's office said", "1 killed, 1 wounded in unclear shooting; suspect in custody", "A 17-year-old who was hunting fired his 12-gauge shotgun at a running deer. The 13-year-old stood up in the path of the shooter and was hit.", "Officer Ricky Galvez, a 29-year-old Marine who served two tours of duty in Iraq and Afghanistan, was seated in his personal car when two attackers approached and opened fire", "19-year-old Kevontae Jones was shot at 5 a.m. in the 100 block of Danbury Street SW", "Police located a 44-year-old man with a gunshot wound to the upper body.", "Around 5:40 p.m. James drove five minutes away from his house to Watkins Drive and Beaverbrook where he allegedly unloaded on a JATRAN bus.", "A 10th grader's dead body was found along a foot path in a wooded area near E. 25th Avenue", "The victim's mother came home from work Friday morning to find her son dead", "Police believe Payne was shot in the 1900 block of Tree House Lane.", "Coffee man murdered two individuals.", "Police found him dead of a gunshot wound and evidence that his body had been moved and the scene cleaned and altered.", "Sheriff's deputies responding to the call of shots fired found a vehicle in a ditch with the body of a dead man inside.", "The city's ShotSpotter detection system recorded as many as six shots fired in the area of Sachem Street. Springfield police spokesman Sgt. John Delaney said Taitt was killed by a single gunshot wound. Delaney said police are still looking for suspects in the shooting. There have been no arrests.", "The victim, whose name has not been released, was shot at least once in the head and had been shot several hours before his sister came to the home to check on her brother.", "St. Lucie County Sheriff Ken Mascara says a St. Lucie County man accidentally shot and killed his fiancée on November 19.", "Police investigators say the crime took place just after midnight on Nov. 19 when Kerper, 55, was inside his business at 2226 Palmyra Road, located at the Lamar Parr Plaza. Witnesses told police that an unknown male knocked on the front door and asked to come inside. “Words were exchanged” and Keper refused entry to the man", "A Manatee County sheriff's deputy early Thursday shot and killed a man, after he pulled a gun on deputies during a struggle, according to the Manatee County Sheriff's Office.", "Medics transported both to a local hospital shortly after the 1:02 p.m. shooting, police said, but a 15-year-old died shortly afterwards, and a 19-year-old was stabilized and underwent surgery, they said", "Fort Pierce Police officers fatally shot man attacking girl", "An investigation is underway after a woman came home and found her boyfriend dead near his front door", "Murder/suicide reported in Bradford County", "A man is dead after being shot outside his home in Clinton Tuesday evening", "Andrew Miller, of Empire, died in a local hospital after he was found shot in the upper body in the 100 block of Church Street", "Authorities identify man slain in University City", "Police identify man shot to death in Jacksonville drive-by off Lem Turner Rd.", "Oakland: Livermore shooting suspect found dead after standoff at motel ", "man found shot dead inside home after car registered to home with two bodies shot to death inside found on fire in field near 3000 block of Rosetown Road", "Lakeith Marshaun Lawrence, 20, is charged in the shooting death of 45-year-old Philip Eugene McLean", "Akron man hired bodyguard shortly before being killed in shooting", "Officers arrived at the scene and found two men suffering from gunshot wounds on the sidewalk, according to the LAPD.", "When officers arrived on the scene, they found 23-year-old Latoya Bryant  lying in a yard suffering from a gunshot wound to the head.", "20-year-old Hoveaire Easley was shot outside a residence in the 600 block of Seventh Street following a verbal and physical altercation on the evening of Nov. 19, 2015", "Family of the victim in Charlotte’s most recent homicide said he was killed one day before his son’s eighth birthday.", "Accidental shooting leaves shooter's 15-year-old cousin dead", "Napper was high on PCP at the time of the shooting, D.C. police sources told WUSA9", "Romello Qumar Jacobs, 21, of Hartsville was pronounced dead at the scene by Darlington County Coroner J Todd Hardee.  Jacobs was shot early Thursday evening near Russell Road and Martin Luther King Drive. ", "A Northwest Jacksonville jewelry store owner shot Thursday night in a struggle with two robbers managed to shoot one of the masked men attempting to rob him"};
		
		Random rand

		for (int a = 0; a < array.Length - 1; a = a + 1) {
			Random x = new Random();
			int xInt = x.(0, 25);

			Random z = new Random();
			int zInt = z (0, 25);

			GameObject person = Instantiate (personPrefab);
			GUIText text = person.GetComponent<GUIText> ();
			text.text = array[a];
			Transform transform = person.GetComponent<Transform> ();
			transform.position = new Vector3 (x, 0, z);

			GameObject cube = Instantiate (invisibleCube);
			GUIText displayText = cube.GetComponent<GUIText> ();
			displayText.text = array[a];
			Transform cubeTransform = cube.GetComponent<Transform> ();
			cubeTransform.position = new Vector3 (x, 0, z);
		}
		
	
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
