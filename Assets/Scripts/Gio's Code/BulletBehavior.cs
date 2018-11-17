using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

	// Use this for initialization
	public GameObject hitDoggo;

	private GameObject myChase;

	private bool hey = true;

	private EnemyChase3 myChaseScript;


	/*void OnCollisionEnter (Collision col)
    {
		myChaseScript = col.gameObject.GetComponent<EnemyChase3>();

        if(col.gameObject.tag == "bullet")
        {
			//myChaseScript.isHit = true;
			//EnemyChase3.isHit = true;
			
			//col.gameObject.GetComponent<EnemyChase3>().isHit = true;
			Debug.Log("collider get but from Bullet Behavior");
        }
    }*/

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
