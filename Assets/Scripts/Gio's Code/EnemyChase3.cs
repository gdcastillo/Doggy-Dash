using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase3 : MonoBehaviour {

	public Transform player;
	public Transform secondaryTarget;
	public float smoothTime = 0.6f;
	public float moveSpeed = 1;

	public bool folowPrimary = true;

	private Vector3 smoothVelocity = Vector3.zero;

	Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		if (rb != null)
		rb.velocity = Vector3.zero;


		if (Input.GetKeyDown(KeyCode.Space))
		{

			folowPrimary = !folowPrimary;


		}

		if (folowPrimary)
		{

			transform.LookAt(player);
		}
		else
		{

			transform.LookAt(secondaryTarget);			
		}

		//transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

			//for linear movement:





	}
}
