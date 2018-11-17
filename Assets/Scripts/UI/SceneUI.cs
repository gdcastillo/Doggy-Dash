using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneUI : MonoBehaviour 
{
	[Header ("PopUp")]
	[SerializeField]
	private GameObject pausemenuPopUp;
	[SerializeField]
	private GameObject endmenuPopUp;

	/*
	void Awake()
	{
		Toggle soundtog = GameObject.Find("Sound_Toggle").GetComponent<Toggle>();

		if (soundtog.isOn) 
		{
			DontDestroyOnLoad(this.gameObject);
			ButtonSound.mute = false;
			ButtonSound.Play ();
			Debug.Log ("Meow");
		} else 
		{
			ButtonSound.mute = true;
			Debug.Log ("Roff");
		}
	}
	*/

	private void Start ()
	{
		Time.timeScale = 1;
		pausemenuPopUp.SetActive (false);
		endmenuPopUp.SetActive (false);
	}

	private void Update ()
	{
		if (Time.timeScale == 0) 
		{
			return;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Debug.Log("pause menu");
			if (endmenuPopUp.activeInHierarchy == false) //if end menu not visible
			{
				if (pausemenuPopUp.activeInHierarchy == false) //if pause menu not visible
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

			/*
			if (endmenuPopUp.activeInHierarchy == true) 
			{
				Time.timeScale = 0;
			}
			*/

		}
		
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
		SceneManager.LoadScene (1);
	}

	public void GoToMain()
	{
		SceneManager.LoadScene (0);
	}

	public void GoToUpgrade()
	{
		SceneManager.LoadScene (3);
	}

}
