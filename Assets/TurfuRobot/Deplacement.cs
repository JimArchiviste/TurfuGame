using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey (KeyCode.Q)) {
			transform.Translate (Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, 0, 180);
		}

		if (Input.GetKey (KeyCode.Z)) {
			transform.Translate (Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, 0, 90);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, 0, -90);
		}
	}
}
