using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonPanel : MonoBehaviour {

	CommonParameter commonParameter;
	public Text goldText;
	public Text cleanlinessText;

	// Use this for initialization
	void Start () {
		commonParameter = FindObjectOfType<CommonParameter>();
	}
	
	// Update is called once per frame
	void Update () {
		if(commonParameter.initialized)
		{
			Initialize();
			commonParameter.initialized = false;
		}
	}

	void Initialize()
	{
		goldText.text = commonParameter.gold.ToString("N0");
		cleanlinessText.text = commonParameter.cleanliness.ToString("N0");
	}
}
