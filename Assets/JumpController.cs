using UnityEngine;
using System.Collections;

public class JumpController : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
		Debug.Log("Entered");
	}

}
