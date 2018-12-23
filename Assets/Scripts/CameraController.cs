using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	void Update() {
		//yaw += speedH * Input.GetAxis("Mouse X");
		//pitch -= speedV * Input.GetAxis("Mouse Y");

		//transform.position = new Vector3 (pitch, yaw, 0.0f);
		//transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
		//transform.LookAt(target);
		//transform.Translate(Vector3.right * 0.5f);
	}

	void FixedUpdate() {

	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset; 
	}
}
