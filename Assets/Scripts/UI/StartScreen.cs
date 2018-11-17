using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour 
{
	[Header ("Audio")]
	[SerializeField]
	private AudioSource ButtonSound;
	[SerializeField]
	private AudioSource MusicSound;

	[Header ("PopUp")]
	[SerializeField]
	private GameObject howtoPopUp;
	[SerializeField]
	private GameObject startmenuPopUp;

	[SerializeField]
	private GameObject dropdown;

	void Start ()
	{
		//MUST UTILIZE THE UTIL SCRIPT
		//Debug.Log (Utils.splash_active);
		if(Utils.splash_active == false)
		{
			startmenuPopUp.SetActive (false);
		}
		else
		{
			startmenuPopUp.SetActive (true);
			Utils.splash_active = false;
			//Debug.Log (Utils.splash_active);
		}
		/*
		startmenuPopUp.SetActive (false);

		if (Utils.GetBool ("isAppLaunchedFirstTime")) 
		{
			Utils.SetBool ("isAppLaunchedFirstTime", true);
			startmenuPopUp.SetActive (true);
			Debug.Log("app launched first time");

			if (startmenuPopUp.activeInHierarchy == true)
			{
				Debug.Log("now it's off?");
				Utils.SetBool ("isAppLaunchedFirstTime", false);
			}
		} 
		else
		{
			Debug.Log("app already launched");
			startmenuPopUp.SetActive (true);
			howtoPopUp.SetActive (false);
		}
		*/
	}

	private void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			startmenuPopUp.SetActive (false);
		}
	}

	public void dropDown()
	{
		if(dropdown.activeInHierarchy == false)
		{
			dropdown.SetActive(true);
		}
		else
		{
			dropdown.SetActive(false);
		}
	}

	public void OnTriggerDown()
	{
		ButtonSound.Play ();
	}

	public void LoadGame()
	{
		SceneManager.LoadScene (1);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene (0);
	}

	public void HowTo()
	{
		SceneManager.LoadScene (2);
	}

	public void ExitGame()
	{
		Application.Quit ();
		Debug.Log ("Closed");
	}
}
