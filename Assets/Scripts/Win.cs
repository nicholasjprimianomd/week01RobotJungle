using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win :MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		SceneManager.LoadScene (Application.loadedLevel + 1);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
