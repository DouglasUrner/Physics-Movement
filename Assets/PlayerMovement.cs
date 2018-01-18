using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float xSpeed = 1f;
	public float ySpeed = 1f;
	public float hopPower = 20f;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		Vector3 impulse = new Vector3(
			xSpeed * Input.GetAxis("Horizontal"),
			ySpeed * Input.GetAxis("Vertical"),
			0 // Keyboard only gives us two axes.
			);
		
		// Use space bar to hop.
		if (Input.GetKeyDown(KeyCode.Space))
		{
			impulse.y += hopPower;
		}
		
		rb.AddForce(impulse);
	}
}
