using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {


	public int layer;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {

		RaycastHit hit;

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		

		if (Physics.Raycast(ray, out hit, 5000, 1 << layer))
		{

		 //if (hit != null)
		 //{
		 
		 	Vector3 dir = hit.point;
			 transform.LookAt(new Vector3(dir.x, transform.position.y, dir.z), transform.up);


         	//float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
         	//transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);		
		 //}

		}



		//Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
         //float angle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
         //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


	}
}
