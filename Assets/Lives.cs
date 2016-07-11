using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	private int lives = 3;
	private string strLives;

	private GUIStyle guiStyle = new GUIStyle();

	void Awake(){
		GameObject.DontDestroyOnLoad(this);
	}

	void OnGUI(){
		//GUI.Label (new Rect (800, 10, 500, 200), strLives, guiStyle);
	}

	void Update(){
		strLives = lives.ToString();
	}

	void OnTriggerEnter2D(Collider2D other){
		lives--;
	}



}
