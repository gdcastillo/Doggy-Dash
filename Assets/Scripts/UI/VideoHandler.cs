using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoHandler : MonoBehaviour 
{
	RawImage raw;
	MovieTexture m;

	// Use this for initialization
	void Start () 
	{
		raw = GetComponent<RawImage> ();
		m = (MovieTexture)raw.mainTexture;
	}
	
	// Update is called once per frame
	void Update () 
	{
		m.Play ();
		m.loop = (true);
	}
}

