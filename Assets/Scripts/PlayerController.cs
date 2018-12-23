using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpSpeed;

	private Rigidbody rb;
	private Vector3 movement;
	private Terrain other;

	bool isGrounded = false;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		other = GetComponent<Terrain> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveUp = Input.GetAxis ("Jump");
				
		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		if (isGrounded) {
			movement.y = moveUp * jumpSpeed;
		}

		rb.AddForce (movement * speed);
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Terrain") {
			isGrounded = true;
			Debug.Log (isGrounded);
		}
		
	}
	
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.name == "Terrain") {
			isGrounded = false;
			Debug.Log(isGrounded);	
		}
	}
}