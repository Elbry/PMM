using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonParameter : MonoBehaviour {

	public int gold;
	public int cleanliness;
	
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
		gold = PlayerPrefs.GetInt("money", 2000);
		cleanliness = PlayerPrefs.GetInt("cleanliness", 100);

		initialized = true;
	}
}
