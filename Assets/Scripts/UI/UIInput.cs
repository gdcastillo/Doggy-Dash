using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIInput : MonoBehaviour 
{
	[Header ("Audio")]

	[SerializeField]
	private AudioSource ButtonSound;

	[SerializeField]
	private GameObject howtoplayPopUp;
	[SerializeField]
	private GameObject aboutPopUp;

	void Start ()
	{
		howtoplayPopUp.SetActive (false);
		aboutPopUp.SetActive (false);
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

	public void ExitGame()
	{
		Application.Quit ();
		Debug.Log ("Closed");
	}

	public void HowToPlayPopUp()
	{
		howtoplayPopUp.SetActive (true);
	}

	public void AboutPopUp()
	{
		aboutPopUp.SetActive (true);
	}
		
}
