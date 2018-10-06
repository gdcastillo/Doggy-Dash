using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour {

	private void Update ()
	{
		if (Input.anyKeyDown) 
		{
			Application.Quit ();
			Debug.Log ("any key pressed");
		}
	}

}
