using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherParameter : MonoBehaviour {

public enum fatherDream{nonexistant, princessMaking};

	public int strength;
	public int intelligence;
	public int dignity;
	public int sense;
	public int stress;
	public int will;

	public fatherDream firstDream;
	public fatherDream secondDream;

	//bool 변수 만들어서 체크하는 것 말고 방법 없을까? (현재 fatherPanel의 Start()가 먼저 호출되어서 Init된 것이 UI에 안 뜸)
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
		strength = PlayerPrefs.GetInt("FatherStrength", 500);
		intelligence = PlayerPrefs.GetInt("FatherIntelligence", 100);
		dignity = PlayerPrefs.GetInt("FatherDignity", 100);
		sense = PlayerPrefs.GetInt("FatherSense", 50);
		stress = PlayerPrefs.GetInt("Stress", 0);
		will = PlayerPrefs.GetInt("Will", 0);

		firstDream = (fatherDream)PlayerPrefs.GetInt("FirstDream", 1);
		secondDream = (fatherDream)PlayerPrefs.GetInt("SecondDream", 0);

		initialized = true;
	}

}
