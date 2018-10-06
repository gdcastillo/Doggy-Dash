using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

	// Use this for initialization
	public GameObject deletedDoggo;


	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "bullet")
        {
			EnemyChase3.isHit = true;
			Debug.Log("collider get");
        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
