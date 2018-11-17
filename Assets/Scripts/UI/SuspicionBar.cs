using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspicionBar : MonoBehaviour 
{

	[SerializeField]
	private Image SusBar;
	public GameObject myEnemy;

	public float CurrentSus = 0f;
	public float TotalSus = 100f;

	public float timer = 0f;
	public float waitingTime = 5.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
		
	// Update is called once per frame
	void Update ()
	{
		if (Time.timeScale == 0) 
		{
			//Debug.Log ("Suspicion_return");
			return;
		}

		if(Treats.treats > 0)
		{
			SuspicionCalculate ();
		}

		SuspicionLower();
	}
		
	void SuspicionCalculate () 
	{
		float ratio = CurrentSus / TotalSus;
		SusBar.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		//print (ratio);


		if (Input.GetMouseButtonDown (0) && CurrentSus < 90) //have to figure out how to get the suspicion bar to stop when the treats run out
		{
			CurrentSus += 10;
		}

		if (Input.GetMouseButtonDown (0) && CurrentSus > 90)
		{
			CurrentSus = 100f;
			SusBar.rectTransform.localScale = new Vector3 (1, 1, 1); //In case it's 95 and then 105

			/*
			for (int i = 0; i < 6; i++)
			{
				timer += (Time.deltaTime * 100);
				print ("Timer:"+ timer);

				if (timer > waitingTime) 
				{
					Debug.Log ("timer = 0");
					timer = 0f;
					CurrentSus = 100f;
				}
			}
			*/

		}

		if (CurrentSus >= TotalSus) //Full bar
		{
			Debug.Log ("Another one");
			CurrentSus = 0f;
			SusBar.rectTransform.localScale = new Vector3 (CurrentSus, 1, 1);

			Instantiate(myEnemy, myEnemy.transform.position, myEnemy.transform.rotation);
		}

		//COLOR CHANGE
		if (CurrentSus > 00 && CurrentSus < 49) 
		{
			SusBar.color = Color.green;
		}


		if (CurrentSus >= 50 && CurrentSus < 79) 
		{
			SusBar.color = Color.yellow;
		}

		if (CurrentSus >=  80) 
		{
			SusBar.color = Color.red;
		}
	}

	void SuspicionLower()
	{
		float ratio = CurrentSus / TotalSus;
		SusBar.rectTransform.localScale = new Vector3 (ratio, 1, 1);

		if (CurrentSus <= 90 && CurrentSus > 0) //Not Full Bar & Not at 0
		{
			CurrentSus -= 1 * Time.deltaTime;

			float ration = CurrentSus / TotalSus;
			SusBar.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		}

	}
		

	IEnumerator Wait()
	{
		print(Time.time);
		yield return new WaitForSeconds(5);
		print(Time.time);
	}
		
}
