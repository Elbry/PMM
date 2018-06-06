using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatherPanel : MonoBehaviour {

	FatherParameter fatherParameter;
	public Text firstDreamText;
	public Text secondDreamText;
	public Text strengthText;
	public Text intelligenceText;
	public Text dignityText;
	public Text senseText;
	public Text stressText;
	public Text willText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void InitializeByStart() {
		fatherParameter = FindObjectOfType<FatherParameter>();
		fatherParameter.Initialize();
		Initialize();
	}

	public void Initialize()
	{
		if(fatherParameter.firstDream == FatherParameter.fatherDream.nonexistant)
		{
			firstDreamText.text = "--";
		}
		else if(fatherParameter.firstDream == FatherParameter.fatherDream.princessMaking)
		{
			firstDreamText.text = "딸을 공주로 만들기";
		}
		
		if(fatherParameter.secondDream == FatherParameter.fatherDream.nonexistant)
		{
			secondDreamText.text = "--";	
		}

		strengthText.text = fatherParameter.strength.ToString("N0");
		intelligenceText.text = fatherParameter.intelligence.ToString("N0");
		dignityText.text = fatherParameter.dignity.ToString("N0");
		senseText.text = fatherParameter.sense.ToString("N0");
		stressText.text = fatherParameter.stress.ToString("N0");
		willText.text = fatherParameter.will.ToString("N0");
	}
}
