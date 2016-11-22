using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float rotateSpeed;
	public float forwardSpeed;
	public float JumpSpeed = 5.0f;
	private CharacterController playerController;
	private bool canClimb;
	private float gravity = 3f;
	private bool isClimbing;



	// Use this for initialization
	void Start () {
		playerController = GetComponent<CharacterController> ();
	}

	// Update is called once per frame

	void Update () {

		//if (Input.GetKey(KeyCode.Space))

			
		if (Input.GetKeyDown ("space") && !onGround && canDoubleJump) {
				playerController.Move (Vector3.up) ;
			{
				this.GetComponent<Rigidbody>().AddForce (Vector3.up*200);
				canDoubleJump = false;
				}
			else if(Input.GetKeyDown("space") && onGround)

			{
				this.GetComponent<Rigidbody>() .AddForce (Vector3.up*200);
				canDoubleJump = true;
			}

		if (!isClimbing) {
			transform.Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
			Vector3 forward = transform.TransformDirection (Vector3.forward);
			float speed = forwardSpeed * Input.GetAxis ("Vertical");
			playerController.Move (speed * forward * Time.deltaTime);
		}
		if (!playerController.isGrounded) {
			playerController.Move (-Vector3.up * gravity * Time.deltaTime);
		}



			if(Input.GetKey(KeyCode.E) && canClimb){
			playerController.Move (Vector3.up* 0.25f);
			isClimbing = true;



			}

		if (isClimbing) {
			if (Input.GetKey (KeyCode.W)) {
				playerController.Move (Vector3.up * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.S)) {
				playerController.Move(-Vector3.up * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.Space)) {
				playerController.Move(-Vector3.forward*.5f);
			}
		}




	}
	//Collectible and climbing script below
	
		void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Collectible"))
		{
			other.gameObject.SetActive (false);
			}
	
		if (other.gameObject.CompareTag("Rope"))
		{
			canClimb = true;
			gravity = 0;
		}
		
		
	}

	void OnTriggerExit(Collider other)
	{if (other.gameObject.CompareTag ("Rope")) {
			canClimb = false;
			isClimbing = false;
			gravity = 10;
		}
	}
}
