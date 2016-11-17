using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {
	private CharacterController controller;

	private float verticalVelocity;
	private float gravity = 14.0f;
	private float JumpForce = 10.0f;

	// Use this for initialization
	private void Start () {
	
		controller = GetComponent<CharacterController>();

	}
	private void Update()
	{
		if(controller.isGrounded)
	    {
			verticalVelocity = -gravity * Time.deltaTime;
			if(Input.GetKeyDown(KeyCode.Space))
			{	
				verticalVelocity = JumpForce;
			}
		}
		else
	{
			verticalVelocity -= gravity * Time.deltaTime;
		}
		Vector3 moveVector = new Vector3 (0, verticalVelocity,0);

		moveVector.x = Input.GetAxis ("Horizontal") * 5.0f;
		moveVector.y = verticalVelocity;
		moveVector.z = Input.GetAxis ("Vertical") * 5.0f;
		controller.Move(moveVector * Time.deltaTime);
	
	}
}