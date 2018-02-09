using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	float timeLeft = 120.0f;
	void Update(){
		timeLeft -= Time.deltaTime;
	}
	void OnGUI(){
		if (timeLeft >= 0) {
			string formatTime = string.Format ("{0:00}", timeLeft);
			GUI.Label (new Rect (10, 10, 250, 100), formatTime);
		} else {
			GUI.Label (new Rect (10, 10, 250, 100), "Game Over");
		}

	}
}

