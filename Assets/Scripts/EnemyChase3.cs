using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase3 : MonoBehaviour {

	public Transform player;
	public float smoothTime = 0.6f;

	private Vector3 smoothVelocity = Vector3.zero;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player);

		transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
	}
}
