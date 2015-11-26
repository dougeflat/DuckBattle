using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class duckSceneController : MonoBehaviour {
	public GameObject duck;
	public GameObject duckClone;
	private int frameCounter = 0;
	public int score = 0;
	private float timeLeft = 30;
	public Text timeDisplay;

	void Start () {
//		timeDisplay = GameObject.Find ("Timer");
//		GameObject.Find ("Timer").GUIText.text = timeLeft.ToString();
		timeDisplay.text = timeLeft.ToString();
		InvokeRepeating ("Countdown", 1.0f, 1.0f);
	}
	
	void Update () {
		LaunchDucks ();
	}

	void LaunchDucks () {
		frameCounter++;
		int timeInterval = Random.Range (100, 150);
		if (frameCounter % timeInterval==0) {
			float startingX = 12;
			float startingY = -3;
			float spacingY = 2;
			int whichLine = Random.Range (1, 4);
			float thisY = startingY + (spacingY * whichLine);
			duckClone = (GameObject) Instantiate(duck, new Vector2(startingX,thisY), Quaternion.identity);
		}
	}

	void Countdown () {
		if (--timeLeft == 0) {
			CancelInvoke ("Countdown");
			GameOver ();
		}
		timeDisplay.text = timeLeft.ToString();
	}

	void GameOver () {

	}
}
