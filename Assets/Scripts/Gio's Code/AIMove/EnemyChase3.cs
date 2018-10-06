using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase3 : MonoBehaviour {


	public ArrayList dogFollow = new ArrayList();
	public Transform player;
	public Transform secondaryTarget;
	public float smoothTime = 0.6f;
	public float moveSpeed = 1;

	public bool folowPrimary = true;

	public static bool isHit = false;

	private Vector3 smoothVelocity = Vector3.zero;

	int count = 0;

	Rigidbody rb;

	EnemyChase3(Transform myFollow2, bool myIsHit){	//because the first target it follows will always be the player
		secondaryTarget = myFollow2;
		isHit = myIsHit;
	}

	// Use this for initialization
	void Start () {

		rb.GetComponent<Rigidbody>();

		dogFollow.Add(new EnemyChase3(null, false));
		count++;

	}

	//
	
	// Update is called once per frame
	void Update () {

		if(isHit == true){

			//dogFollow.Add(new EnemyChase3((Transform)dogFollow[count-1],true));
			//count++;
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
		}

				//for linear movement:





	}
}
