using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase2 : MonoBehaviour {
	

	public Transform Character;	//position, rotation scale
	
	public float speed = 0.1f;
	private Vector3 directionOfCharacter;

	private bool challenged = true;		//change this later


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(challenged){
			directionOfCharacter = Character.transform.position - transform.position;
			directionOfCharacter = directionOfCharacter.normalized;
			transform.Translate(directionOfCharacter * speed, Space.World);	//transform the gameObject using the world's coordinates (not local space)
		}
	}
}
