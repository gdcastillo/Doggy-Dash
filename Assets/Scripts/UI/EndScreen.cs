using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

	[SerializeField]
	private GameObject endscreenPopUp;

	private void Update ()
	{
		if (Input.anyKeyDown) 
		{
			Application.Quit ();
			Debug.Log ("any key pressed");
		}
	}

}
