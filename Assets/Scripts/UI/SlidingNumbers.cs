using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidingNumbers: MonoBehaviour 
{
	[SerializeField]
	private GameObject endmenuPopUp;

	public Text coinsText;
	public Text coinsEarned; 
	public Text dogsSaved;
	public float animationTime = 5.0f; //time it takes to complete the animation

	private float totalNumber;
	private float initialNumber;
	private float currentNumber = 0.0f;

	private float currentNumber2 = 0.0f;
	private float dogsSaved_Cal;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (endmenuPopUp.activeInHierarchy == true) 
		{
			//string str_coins = coinsText.ToString();
			//float coins = coinsText.ValueOf (str_coins);
			//initialNumber = currentNumber;
			totalNumber = float.Parse(coinsText.text);
			Debug.Log ("total: " + (totalNumber));

			dogsSaved_Cal = totalNumber / 5; 
			//dogsSaved.text = dogsSaved_Cal.ToString("0");
			//desiredNumber += float.Parse(coinsText.text);
			//coinsEarned.text = totalNumber.ToString();

			if (currentNumber < totalNumber) 
			{
				//THIS "- currentNumber" makes the numbers slow down towards the end
				//currentNumber += (animationTime * (Time.deltaTime)) * (totalNumber - currentNumber);
				currentNumber += (animationTime * (Time.deltaTime)) * (totalNumber - currentNumber);
				currentNumber2 += (animationTime * Time.deltaTime) * (dogsSaved_Cal - currentNumber2);
				Debug.Log ("time: " + (Time.deltaTime)); 

				dogsSaved.text = currentNumber2.ToString("0");
				coinsEarned.text = currentNumber.ToString("0");


			}
		}

	}
}
