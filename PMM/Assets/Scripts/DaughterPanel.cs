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
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void InitializeByStart() {
		daughterParameter = FindObjectOfType<DaughterParameter>();	
		daughterParameter.Initialize();
		Initialize();
	}

	public void Initialize()
	{
		strengthText.text = daughterParameter.strength.ToString("N0");
		intelligenceText.text = daughterParameter.intelligence.ToString("N0");
		dignityText.text = daughterParameter.dignity.ToString("N0");
		senseText.text = daughterParameter.sense.ToString("N0");
	}
}
