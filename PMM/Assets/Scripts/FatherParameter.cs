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

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Initialize()
	{
		strength = PlayerPrefs.GetInt("FatherStrength", 500);
		intelligence = PlayerPrefs.GetInt("FatherIntelligence", 100);
		dignity = PlayerPrefs.GetInt("FatherDignity", 100);
		sense = PlayerPrefs.GetInt("FatherSense", 50);
		stress = PlayerPrefs.GetInt("Stress", 0);
		will = PlayerPrefs.GetInt("Will", 0);

		firstDream = (fatherDream)PlayerPrefs.GetInt("FirstDream", 1);
		secondDream = (fatherDream)PlayerPrefs.GetInt("SecondDream", 0);
	}

	public void Save(){
		PlayerPrefs.SetInt("FatherStrength", strength);
		PlayerPrefs.SetInt("FatherIntelligence", intelligence);
		PlayerPrefs.SetInt("FatherDignity", dignity);
		PlayerPrefs.SetInt("FatherSense", sense);
		PlayerPrefs.SetInt("Stress", stress);
		PlayerPrefs.SetInt("Will", will);

		PlayerPrefs.SetInt("FirstDream", (int)firstDream);
		PlayerPrefs.SetInt("SecondDream", (int)secondDream);
	}

}
