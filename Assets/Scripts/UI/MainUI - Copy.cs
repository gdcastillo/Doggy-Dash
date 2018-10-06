using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUCopy : MonoBehaviour 
{
	[SerializeField]
	private GameObject escPopUp;
	[SerializeField]
	private GameObject winlosePopUp;
	[SerializeField]
	private GameObject winlose2PopUp;
    [SerializeField]
    private GameObject drawpopup;
    [SerializeField]
	private GameObject howtoplayPopUp;
	[SerializeField]
	private GameObject howtoplay2PopUp;
	[SerializeField]
	private GameObject howtoplay3PopUp;
	[SerializeField]
	private GameObject howtoplay4PopUp;


	private void Start ()
	{
		Time.timeScale = 1;
		escPopUp.SetActive (false);
		winlosePopUp.SetActive (false);
		winlose2PopUp.SetActive (false);
        drawpopup.SetActive(false);
    }

	private void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (winlosePopUp.activeInHierarchy == false) 
			{
				if (escPopUp.activeInHierarchy == false) {
					Time.timeScale = 0;
					escPopUp.SetActive (true);
				} else {
					Time.timeScale = 1;
					escPopUp.SetActive (false);
				}
			}
		}
	}
		

	public void ExitGame()
	{
		Application.Quit ();
		Debug.Log ("Closed");
	}

	public void PopUp ()
	{
		Time.timeScale = 0;
		escPopUp.SetActive (true);
		howtoplayPopUp.SetActive (false);
		howtoplay2PopUp.SetActive (false);
		howtoplay3PopUp.SetActive (false);
		howtoplay4PopUp.SetActive (false);

	}

	public void ResumeGame()
	{
		Time.timeScale = 1;
		escPopUp.SetActive (false);
	}
		
	public void EscMenu()
	{
		Time.timeScale = 0;
		escPopUp.SetActive (true);
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
