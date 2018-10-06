﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
         float angle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
         transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


	}
}
