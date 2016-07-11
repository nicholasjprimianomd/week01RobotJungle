using UnityEngine;
using System.Collections;

public class DeathSound : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
			//New Code Death Sound
			Debug.Log ("Death sound");
			AudioSource audio = GetComponent<AudioSource>();
			audio.PlayDelayed(0);
	}
}
