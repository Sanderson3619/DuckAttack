using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOmovement : MonoBehaviour {

	private float speed = 2f;


	// Use this for initialization
	void Start () {
		Vector2 angle = new Vector2 (-1, 0.5f);
		GetComponent<Rigidbody2D> ().velocity = angle * speed;
	}
	
	// Update is called once per frame
	void Update () {
		float xpos = GetComponent<Rigidbody2D> ().transform.position.x;
		float ypos = GetComponent<Rigidbody2D> ().transform.position.y;

		Vector2 angle = new Vector2 (0, 0);

		if (xpos <= -7.2) {
			angle = new Vector2 (1, 0);
		}
		if (xpos >= 7.2) {
			angle = new Vector2 (-1, 0);
		}
		if (ypos <= -3) {
			angle = new Vector2 (0, 0.5f);
		}

		if (ypos >= 3) {
			angle = new Vector2 (0, -0.5f);
		}

		GetComponent<Rigidbody2D> ().velocity = (GetComponent<Rigidbody2D>().velocity * (1/speed) + angle) *speed;
	}
}
