using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour {
	public float maxSpeed;
	Rigidbody rb;
	private float speed;
	private float rotSpeed;
	// Use this for initialization
	void Start () {
		rb = GetComponent< Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		speed = Input.GetAxis ("Vertical");
		rotSpeed = Input.GetAxis ("Horizontal");
		//Vector3 movement = new Vector3 (0, 0, speed) * maxSpeed * Time.deltaTime;
		Vector3 tempVel = rb.velocity;
		tempVel.x = speed * maxSpeed;
		rb.velocity = tempVel;

	}
}
