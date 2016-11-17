using UnityEngine;
using System.Collections;

public class damagePlayer : MonoBehaviour {
	public int playerHealth = 10;
	int damage = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision _Collision)
	if(Collision.GameObject.tag == "enemy"){
}
