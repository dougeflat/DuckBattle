// Controls the cannon position and shooting

using UnityEngine;
using System.Collections;

public class CannonController : MonoBehaviour {

	public float speed;
	public GameObject cannonballPrefab;
	public float fireRate;
	private float nextFire;
	public GameObject ballInstance;

	void Start () {
	
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Space) && Time.time > nextFire) {	
			nextFire = Time.time + fireRate;
			ballInstance = (GameObject)Instantiate(cannonballPrefab, transform.position, Quaternion.identity);
		}

	}
	
}
