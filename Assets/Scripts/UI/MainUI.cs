using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour 
{
	[Header ("Audio")]
	[SerializeField]
	private AudioSource ButtonSound;


	[SerializeField]
	private GameObject pausemenuPopUp;
	[SerializeField]
	private GameObject endmenuPopUp;

	private void Start ()
	{
		Time.timeScale = 1;
		pausemenuPopUp.SetActive (false);
		endmenuPopUp.SetActive (false);
	}

	private void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Debug.Log("pause menu");
			if (endmenuPopUp.activeInHierarchy == false) 
			{
				if (pausemenuPopUp.activeInHierarchy == false) 
				{
					Time.timeScale = 0;
					pausemenuPopUp.SetActive (true);
				} else {
					Time.timeScale = 1;
					//areyousurePopUp.SetActive (false);
					pausemenuPopUp.SetActive (false);
					endmenuPopUp.SetActive (false);
				}
			}

		}
	}

	public void OnTriggerDown()
	{
		ButtonSound.Play ();
	}

	public void ResumeGame()
	{
		Time.timeScale = 1;
		pausemenuPopUp.SetActive (false);
		endmenuPopUp.SetActive (false);
	}

	/*
	public void EscMenu()
	{
		Time.timeScale = 0;
		escPopUp.SetActive (true);
		areyousurePopUp.SetActive (false);
	}
	*/

	public void RestartGame()
	{
		SceneManager.LoadScene (2);
	}

	public void GoToMain()
	{
		SceneManager.LoadScene (0);
	}

}
