using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		bool isCrouching = false;
		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer> (); 
		if (Input.GetKeyDown (KeyCode.C) && !isCrouching) {
			sr.transform.Rotate (Vector3.forward * 90);
			isCrouching = true;
		}
		if (Input.GetKeyUp (KeyCode.C)) {
			sr.transform.Rotate (Vector3.forward * -90);	
		}
	}
}
