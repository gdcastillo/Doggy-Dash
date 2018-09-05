using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {


	[SerializeField] private float moveSpeed = 10.0f;
	private Rigidbody rbd;
	private float moveX;
	private float moveZ;
	private Vector3 moveDirection;



	void Start () {
		rbd = gameObject.GetComponent<Rigidbody>();	//setting rbd equal to our object's rigidbody
	}
	
	// Update is called once per frame
	void Update () {
		
		moveX = Input.GetAxis("Horizontal");
		moveZ = Input.GetAxis("Vertical");

		moveDirection = new Vector3(moveX, 0.0f, moveZ);

		rbd.AddForce(moveDirection * moveSpeed);
	}

}
