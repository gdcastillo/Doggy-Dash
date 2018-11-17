using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treats : MonoBehaviour
{

	public Text treatsText;

	[SerializeField]
	public static float treats;

	// Use this for initialization
	void Start () 
	{
		treats = 20.0f;
		string str_treats = treats.ToString();
		treatsText.text = str_treats;
		//Debug.Log ("work??");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.timeScale == 0) 
		{
			//Debug.Log ("Treats_return");
			return;
		}
			
		//Input.GetMouseButton(0) = long/hold click
		//Input.GetMouseButtonDown(0) = short/once click
		if (Input.GetMouseButtonDown (0) && treats > 0) //0 for left button, 1 for right button, 2 for middle button
		{
			treats = treats - 1;

			string str_treats = treats.ToString ();
			treatsText.text = str_treats;
			//Debug.Log ("Treat shot");
		} 

		if (Input.GetMouseButtonDown (0) && treats == 0)
		{
			treats = 0;
			string str_treats = treats.ToString ();
			treatsText.text = str_treats;
		}
	}
}
