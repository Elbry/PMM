using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaughterPanel : MonoBehaviour {

	DaughterParameter daughterParameter;
	public Text strengthText;
	public Text intelligenceText;
	public Text dignityText;
	public Text senseText;

	// Use this for initialization
	void Start () {
		daughterParameter = FindObjectOfType<DaughterParameter>();	
	}
	
	// Update is called once per frame
	void Update () {
		if(daughterParameter.initialized)
		{
			Initialize();
			daughterParameter.initialized = false;
		}
	}

	void Initialize()
	{
		strengthText.text = daughterParameter.strength.ToString("N0");
		intelligenceText.text = daughterParameter.intelligence.ToString("N0");
		dignityText.text = daughterParameter.dignity.ToString("N0");
		senseText.text = daughterParameter.sense.ToString("N0");
	}
}
