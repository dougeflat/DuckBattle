// Handle Cannonball Movement
using UnityEngine;
using System.Collections;

public class CannonBallHandler : MonoBehaviour {

	public Vector2 speed = new Vector2(0,0);

	void Start () {
	
	}
	
	void Update () {
		transform.Translate (speed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Duck") {
			Destroy (other.gameObject);
		}
	}
	
}
