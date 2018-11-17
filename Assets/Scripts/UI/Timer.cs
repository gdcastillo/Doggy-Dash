using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour 
{
	[Header ("PopUp")]
	[SerializeField]
	private GameObject endmenuPopUp;

	public Text timerText;


	[SerializeField]
	private float timeLeft; //measured in secs

	// Use this for initialization
	void Start () 
	{
		//timeLeft = 3.0f; //mesaured in secs

		Time.timeScale = 1;
		endmenuPopUp.SetActive (false);
		//Debug.Log ("Countdown Begins");
	}
	
	// Update is called once per frame
	void Update ()
	{
		//System.Convert.ToInt32;
		if (timeLeft < 0) 
		{
			GameOver ();
		}

		if (timeLeft >= 0) //this if statement is so it doesn't go into negatives
		{
			timeLeft -= Time.deltaTime;
			string minutes = ((int) timeLeft / 60).ToString (); //Int removes all decimals
			string seconds = ((int) timeLeft % 60).ToString("F0"); //% = mod operator. Takes remainder of divison. F0 takes no decimals 

			if (Convert.ToInt32(seconds) == 60) 
			{
				Debug.Log ("60!");
				minutes = (((int) timeLeft / 60) + 1).ToString (); 
				timerText.text = minutes + ": 00";
			}

			if(Convert.ToInt32(seconds) < 10 && Convert.ToInt32(seconds) != 60) //adds an extra 0 for the 0:02 look instead of 0:2
			{
				timerText.text = minutes + ":" + "0" + seconds;
			} else 
			{
				timerText.text = minutes + ":" + seconds;
			}
		}
	}

	void GameOver()
	{
		timerText.color = Color.red;

		//Time.timeScale = 0;
		endmenuPopUp.SetActive (true);
		//Debug.Log ("GameOver");
	}
}
