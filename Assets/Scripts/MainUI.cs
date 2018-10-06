using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour 
{
	[SerializeField]
	private GameObject escPopUp;
	[SerializeField]
	private GameObject areyousurePopUp;
	[SerializeField]
	private GameObject winlosePopUp;

	private void Start ()
	{
		Time.timeScale = 1;
		escPopUp.SetActive (false);
		winlosePopUp.SetActive (false);
	}

	private void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (winlosePopUp.activeInHierarchy == false) 
			{
				if (escPopUp.activeInHierarchy == false) {
					Time.timeScale = 0;
					areyousurePopUp.SetActive (false);
					escPopUp.SetActive (true);
				} else {
					Time.timeScale = 1;
					areyousurePopUp.SetActive (false);
					escPopUp.SetActive (false);
				}
			}
		}
	}

	public void ResumeGame()
	{
		Time.timeScale = 1;
		areyousurePopUp.SetActive (false);
		escPopUp.SetActive (false);
	}

	public void AreYouSure()
	{
		Time.timeScale = 0;
		areyousurePopUp.SetActive (true);
	}

	public void EscMenu()
	{
		Time.timeScale = 0;
		escPopUp.SetActive (true);
		areyousurePopUp.SetActive (false);
	}

	public void PlayAgain()
	{
		SceneManager.LoadScene (1);
	}

	public void GoToMain()
	{
		SceneManager.LoadScene (0);
	}

}
