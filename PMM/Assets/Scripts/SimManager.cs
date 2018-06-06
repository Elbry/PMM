using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SimManager : MonoBehaviour {

	CommonPanel commonPanel;
	CommonParameter commonParameter;
	DaughterPanel daughterPanel;
	DaughterParameter daughterParameter;
	FatherPanel fatherPanel;
	FatherParameter fatherParameter;

	// Use this for initialization
	void Start () {
		commonPanel = FindObjectOfType<CommonPanel>();
		commonParameter = FindObjectOfType<CommonParameter>();
		daughterPanel = FindObjectOfType<DaughterPanel>();
		daughterParameter = FindObjectOfType<DaughterParameter>();
		fatherPanel = FindObjectOfType<FatherPanel>();
		fatherParameter = FindObjectOfType<FatherParameter>();

		Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Initialize() {
		commonPanel.InitializeByStart();
		daughterPanel.InitializeByStart();
		fatherPanel.InitializeByStart();

		// AI 계산 통해 dream 재계산과 이 달의 장소 계산
		// AI 계산
		// 계산대로 dream 바꾸기
		// 계산대로 이 달의 장소 바꾸기

		// 이 달의 장소와 다른 변수에 맞게 선택지 세팅(혹은 세팅하도록 전달)
	}

	public void Restart() {
		PlayerPrefs.DeleteAll();
		commonParameter.Initialize();
		daughterParameter.Initialize();
		fatherParameter.Initialize();
		commonPanel.Initialize();
		daughterPanel.Initialize();
		fatherPanel.Initialize();
	}

	public void Save(){
		commonParameter.Save();
		daughterParameter.Save();
		fatherParameter.Save();
	}

	public void Export(){
		// 텍스트 쓸 준비
		string path = "Assets/Resources/SimData.txt";
		StreamWriter writer = new StreamWriter(path, true);

		// 쓸 텍스트 준비(개월 수도 필요)
		string dateTime = System.DateTime.Now.ToString();
		string fatherData = "Father: ";
		fatherData += "St" + fatherParameter.strength.ToString() + ", ";
		fatherData += "In" + fatherParameter.intelligence.ToString() + ", ";
		fatherData += "Di" + fatherParameter.dignity.ToString() + ", ";
		fatherData += "Se" + fatherParameter.sense.ToString() + ", ";
		fatherData += "Ss" + fatherParameter.stress.ToString() + ", ";
		fatherData += "Wi" + fatherParameter.will.ToString();
		string daughterData = "Daughter: ";
		daughterData += "St" + daughterParameter.strength.ToString() + ", ";
		daughterData += "In" + daughterParameter.intelligence.ToString() + ", ";
		daughterData += "Di" + daughterParameter.dignity.ToString() + ", ";
		daughterData += "Se" + daughterParameter.sense.ToString();
		string commonData = "Money: " + commonParameter.gold.ToString() + ", " 
							+ "Cleanliness: " + commonParameter.cleanliness.ToString();
		string dreamData = "First Dream: " + fatherParameter.firstDream.ToString() + ", " 
							+ "Second Dream: " + fatherParameter.secondDream.ToString();

		// 텍스트 쓰기
		writer.WriteLine(dateTime);
		writer.WriteLine(fatherData);
		writer.WriteLine(daughterData);
		writer.WriteLine(commonData);
		writer.WriteLine(dreamData);

		writer.Close();
	}

}
