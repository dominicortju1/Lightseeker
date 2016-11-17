using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 200f;
	public float rotateSpeed = 5.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		if(Input.GetKey("w")){
			transform.Translate((Vector3.forward) * moveSpeed *  Time.deltaTime);
			Debug.Log ("Pressing W key");

		}

		if(Input.GetKey("s")){
			transform.Translate ((Vector3.back) * moveSpeed * Time.deltaTime);

		}

		if(Input.GetKey("a")){
			transform.Rotate (Vector3.down * rotateSpeed);
			//transform.Translate ((Vector3.left) * moveSpeed * Time.deltaTime);
			Debug.Log ("pressing A key");

		}

		if(Input.GetKey("d")){
			transform.Rotate (Vector3.up * rotateSpeed);
			//transform.Translate ((Vector3.right) * moveSpeed * Time.deltaTime);

			Debug.Log ("pressing A key");

		}

		if(Input.GetMouseButton(1)){
			moveSpeed = 5f;
			Debug.Log ("Mouse Button");

		}

		if(Input.GetMouseButton(1)){
			moveSpeed = 5f;

		}

		if(Input.GetMouseButton(1)){
			Debug.Log ("Mouse Button Left");
		}

	}
}