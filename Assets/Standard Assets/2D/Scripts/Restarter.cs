using System;
using UnityEngine;
using UnityEngine.SceneManagement;
	
    public class Restarter : MonoBehaviour
    {
	

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);

			//New Code Death Sound
			Debug.Log ("Death sound");
			AudioSource audio = GetComponent<AudioSource>();
			audio.PlayDelayed(0);
			}
        }


		private float timer = 0;
		void Update(){
			timer += Time.deltaTime;
		}

		private GUIStyle guiStyle = new GUIStyle();

		void OnGUI(){
			int minutes = Mathf.FloorToInt (timer / 60f);
			int seconds = Mathf.FloorToInt (timer - minutes * 60);
			string time = string.Format ("{0:00}:{1:00}", minutes, seconds);
			GUI.color = Color.black;
			guiStyle.fontSize = 20;
			GUI.Label (new Rect (10, 10, 500, 200), "Game Timer :", guiStyle);
			GUI.Label (new Rect (136, 10, 500, 200), time, guiStyle);
		}

    }

