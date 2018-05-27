using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaughterParameter : MonoBehaviour {

	public int strength;
	public int intelligence;
	public int dignity;
	public int sense;

	public bool initialized = false;
	
	SimManager simManager;

	// Use this for initialization
	void Start () {
		simManager = FindObjectOfType<SimManager>();
		Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Initialize()
	{
		strength = PlayerPrefs.GetInt("DaughterStrength", 0);
		intelligence = PlayerPrefs.GetInt("DaughterIntelligence", 0);
		dignity = PlayerPrefs.GetInt("DaughterDignity", 0);
		sense = PlayerPrefs.GetInt("DaughterSense", 0);

		initialized = true;
	}
}
