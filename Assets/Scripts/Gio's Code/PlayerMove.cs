using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {


	[SerializeField] private float moveSpeed = 10.0f;
	private Rigidbody rbd;
	private float moveX;
	private float moveZ;
	private Vector3 moveDirection;

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public float bulletVelocity = 6;
	
	public List<EnemyChase3> dogList = new List<EnemyChase3>();

	//[Header ("UI")]
	//[SerializeField]
	//public float treats;

	void Start () 
	{
		rbd = gameObject.GetComponent<Rigidbody>();	//setting rbd equal to our object's rigidbody

		
	}	

	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Mouse0) && Treats.treats > 0)
		{
    		Fire();
		}

		moveX = Input.GetAxis("Horizontal");
		moveZ = Input.GetAxis("Vertical");

		moveDirection = new Vector3(moveX, 0.0f, moveZ);

		rbd.AddForce(moveDirection * moveSpeed);
	}

	void Fire()
	{

		//Aims the gun
		Vector3 aimPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		aimPos.z = 0;
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);
			//Random.rotation

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletVelocity;

		// Destroy the bullet after 2 seconds, CHANGE THIS MOST LIKELY
		Destroy(bullet, 3.0f);

		//Julia: Decrement bullets for UI
		//bulletCount--;
	}

}
