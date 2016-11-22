using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jump : MonoBehaviour {
	public float jumpspeed = 50;  //JUMP HEIGHT
	public bool grounded = false; // TRUE = TITO IS ON THE GROUND
	public int jumps = 0; // COUNTER TO CHECK THE AMOUNT OF JUMPS
	public int maxJumps = 2; // MAX EXTRA JUMPS
	
	void OnCollisionEnter(Collision coll) {
		// CHECK TO SEE IF GROUNDED //
		if (coll.gameObject.name == "Ground") {
			Debug.Log ("Grounded");
			grounded = true;
			jumps = 0;
		}
	}
	
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space) && jumps < maxJumps) {

		
		}
	}
	
	void doublejump() {
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (2, jumpspeed, 2);
		jumps = jumps +1;
	}
}
