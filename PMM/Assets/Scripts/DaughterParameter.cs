using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaughterParameter : MonoBehaviour {

	public int strength;
	public int intelligence;
	public int dignity;
	public int sense;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Initialize()
	{
		strength = PlayerPrefs.GetInt("DaughterStrength", 0);
		intelligence = PlayerPrefs.GetInt("DaughterIntelligence", 0);
		dignity = PlayerPrefs.GetInt("DaughterDignity", 0);
		sense = PlayerPrefs.GetInt("DaughterSense", 0);
	}

	public void Save() {
		PlayerPrefs.SetInt("DaughterStrength", strength);
		PlayerPrefs.SetInt("DaughterIntelligence", intelligence);
		PlayerPrefs.SetInt("DaughterDignity", dignity);
		PlayerPrefs.SetInt("DaughterSense", sense);
	}
}
