using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour 
{
	public Text coinsText;

	[SerializeField]
	public static float coins;

	public static Coins instance = null;

 	private Animator plus_anim;
	private Animation subtract_anim;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}

		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () 
	{
		//plus_anim = GetComponent<Animation>();
		//subtract_anim = gameObject.GetComponent<Animation>();

		string str_coins = coins.ToString();
		coinsText.text = str_coins;
		//Debug.Log ("work??");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.timeScale == 0) 
		{
			//Debug.Log ("Coins_return");
			return;
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			coins += 5;

			string str_coins = coins.ToString ();
			coinsText.text = str_coins;
			//Debug.Log ("Coins colllected");

			plus_anim.SetBool("plus", true);
			//plus_anim = GetComponent<Animation>();
			//plus_anim.Play("plusCoins");
		}
			
		if (Input.GetKeyDown(KeyCode.N)) 
		{
			if (coins >= 5) 
			{
				coins -= 5;

				string str_coins = coins.ToString ();
				coinsText.text = str_coins;
				Debug.Log ("Coins lost");

				subtract_anim = gameObject.GetComponent<Animation>();
				subtract_anim.Play("subtractCoins");
			}
		} 

	}
}
