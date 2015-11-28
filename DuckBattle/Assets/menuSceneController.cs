// Control menu scene

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuSceneController : MonoBehaviour {

	public Canvas quitMenu;
	public Button startButton;
	public Button exitButton;

	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startButton = startButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	public void ExitPress () {
		quitMenu.enabled = true;
		startButton.enabled = false;
		exitButton.enabled = false;
	}

	public void NoPress () {
		quitMenu.enabled = false;
		startButton.enabled = true;
		exitButton.enabled = true;
	}
	
	public void StartLevel () {
		Application.LoadLevel (1);
	}

	public void ExitGame () {
		Application.Quit ();
	}

}
