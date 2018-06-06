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

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void InitializeByStart(){
		commonParameter = FindObjectOfType<CommonParameter>();
		commonParameter.Initialize();
		Initialize();
	}

	public void Initialize()
	{
		goldText.text = commonParameter.gold.ToString("N0");
		cleanlinessText.text = commonParameter.cleanliness.ToString("N0");
	}
}
