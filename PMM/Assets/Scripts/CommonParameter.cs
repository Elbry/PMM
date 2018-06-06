using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonParameter : MonoBehaviour {

	public int gold;
	public int cleanliness;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Initialize()
	{
		gold = PlayerPrefs.GetInt("money", 2000);
		cleanliness = PlayerPrefs.GetInt("cleanliness", 100);
	}

	public void Save(){
		PlayerPrefs.SetInt("money", gold);
		PlayerPrefs.SetInt("cleanliness", cleanliness);
	}
}
