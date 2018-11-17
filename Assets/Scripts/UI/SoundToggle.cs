using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour 
{
	[Header ("Audio")]
	[SerializeField]
	private AudioSource BGMusic;
	[SerializeField]
	public AudioSource ButtonSound;


	[Header ("Toggle")]
	[SerializeField]
	private GameObject soundToggle;
	[SerializeField]
	private GameObject musicToggle;

	// Use this for initialization
	void Start () 
	{
		soundToggle = GameObject.Find ("Sound_Toggle");
		musicToggle = GameObject.Find ("Music_Toggle");
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void OnTriggerDown()
	{
		ButtonSound.Play ();
	}
		

	public void MuteSound()
	{
		Toggle soundtog = GameObject.Find("Sound_Toggle").GetComponent<Toggle>();
		if (soundtog.isOn) 
		{
			//DontDestroyOnLoad(this.gameObject);
			ButtonSound.mute = false;
			ButtonSound.Play ();
			Debug.Log ("Meow");
		} else 
		{
			ButtonSound.mute = true;
			Debug.Log ("Roff");
		}
	}

	public void MuteMusic()
	{
		Toggle musictog = GameObject.Find("Music_Toggle").GetComponent<Toggle>();
		if (musictog.isOn) 
		{
			//DontDestroyOnLoad(this.gameObject);
			BGMusic.mute = false;
			BGMusic.Play ();
			Debug.Log ("Meow");
		} else 
		{
			BGMusic.mute = true;
			Debug.Log ("Roff");
		}
	}


}
