using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

	// Update is called once per frame
	public int speed;
	public GameObject player;
	

	void FixedUpdate () {
		Vector3 localPosition = player.transform.position - transform.position;
	
		localPosition = localPosition.normalized;

		//What are normalized positions

		transform.Translate(localPosition.x * Time.deltaTime * speed, 0.0f, localPosition.z * Time.deltaTime * speed);
	}
}
