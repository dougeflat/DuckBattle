//Handle Duck Movement

using UnityEngine;
using System.Collections;

public class duckHandler : MonoBehaviour {

	public Vector2 speed = new Vector2(0,0);


	void Start () {

	}
	
	void Update () {
		transform.Translate (speed * Time.deltaTime);
		// TODO if duck goes off left of screen, destroy it
	}

}
