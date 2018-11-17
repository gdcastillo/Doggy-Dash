using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlayUI : MonoBehaviour 
{
	[SerializeField]
	private GameObject page01;
	[SerializeField]
	private GameObject page02;
	[SerializeField]
	private GameObject page03;

	// Use this for initialization
	void Start () 
	{
		page01.SetActive (true);
		page02.SetActive (false);
		page03.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void page01_nextButton ()
	{
		page01.SetActive (false);
		page02.SetActive (true);
		page03.SetActive (false);
	}

	public void page02_nextButton ()
	{
		page01.SetActive (false);
		page02.SetActive (false);

		page03.SetActive (true);
	}

	public void page02_backButton ()
	{
		page01.SetActive (true);
		
		page02.SetActive (false);
		page03.SetActive (false);
	}

	public void page03_backButton ()
	{
		page01.SetActive (false);
		page02.SetActive (true);
		page03.SetActive (false);
	}

	public void homeButton ()
	{
		SceneManager.LoadScene (0);
	}
}
