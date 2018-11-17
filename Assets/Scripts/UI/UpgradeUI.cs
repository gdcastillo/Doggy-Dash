using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpgradeUI : MonoBehaviour 
{
	public Text treats01Text;
	public Text coinsText;

	public Text treats02Text;
	public Text treats03Text;

	public static float treats02;
	public static float treats03;

	[Header ("PopUp")]
	[SerializeField]
	private GameObject nomoneyPopUp;

/*
	[Header ("Items")]
	[SerializeField]
	private float treats;
	[SerializeField]
	private float coins;
*/

	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 1;
		nomoneyPopUp.SetActive (false);

		string str_treats01 = Treats.treats.ToString();
		treats01Text.text = str_treats01;

		string str_coins = Coins.coins.ToString();
		coinsText.text = str_coins;

		Debug.Log ("work??");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void GoToNextLevel()
	{
		SceneManager.LoadScene(1);
	}

	public void OKPressed()
	{
		Time.timeScale = 1;
		nomoneyPopUp.SetActive (false);
	}

	public void Purchase01()
	{
		if (Coins.coins >= 5) 
		{
			Treats.treats += 1;
			string str_treats01 = Treats.treats.ToString ();
			treats01Text.text = str_treats01;

			Coins.coins -= 5;
			string str_coins = Coins.coins.ToString ();
			coinsText.text = str_coins;

		} 
		if (Coins.coins < 5 && Coins.coins >= 0)
		{
			Debug.Log ("not enough money");
			Time.timeScale = 0;
			nomoneyPopUp.SetActive(true);
		}
	}

	public void Purchase02()
	{
		if (Coins.coins >= 10) 
		{
			treats02 += 1;
			string str_treats02 = treats02.ToString ();
			treats02Text.text = str_treats02;

			Coins.coins -= 10;
			string str_coins = Coins.coins.ToString ();
			coinsText.text = str_coins;

		} 
		if (Coins.coins == 0)
		{
			Debug.Log ("not enough money");
			Time.timeScale = 0;
			nomoneyPopUp.SetActive(true);
		}
	}

	public void Purchase03()
	{
		if (Coins.coins >= 15) 
		{
			treats03 += 1;
			string str_treats03 = treats03.ToString ();
			treats03Text.text = str_treats03;

			Coins.coins -= 15;
			string str_coins = Coins.coins.ToString ();
			coinsText.text = str_coins;

		} 
		if (Coins.coins < 15 && Coins.coins >= 0)
		{
			Debug.Log ("not enough money");
			Time.timeScale = 0;
			nomoneyPopUp.SetActive(true);
		}
	}
}
