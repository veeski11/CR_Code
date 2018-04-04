using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsManager : MonoBehaviour {
	int kon2,kon3,kon4,kon5;
	public bool isDeleteData;
	public bool kondisi2, kondisi3, kondisi4, kondisi5;

	void Awake(){
		//DontDestroyOnLoad (managers.kondisis1);
		DontDestroyOnLoad (gameObject);
		//DontDestroyOnLoad (kondisii2);
	}

	void Start(){
		kondisi2 = false;
		kondisi3 = false;
		kondisi4 = false;
		kondisi5 = false;

		if (isDeleteData)
			DeleteData ();
		LoadData ();
	}

	public void DeleteData()
	{
		kondisi2 = false;
		kondisi3 = false;
		kondisi4 = false;
		kondisi5 = false;
		SaveData ();
	}
	void LoadData(){

		int tempKondisi2 = PlayerPrefs.GetInt ("maps2");
		int tempKondisi3 = PlayerPrefs.GetInt ("maps3");
		int tempKondisi4 = PlayerPrefs.GetInt ("maps4");
		int tempKondisi5 = PlayerPrefs.GetInt ("maps5");
//		Debug.Log (tempKondisi2);

			
		kondisi2 = tempKondisi2 > 0 ? true : false;
		kondisi3 = tempKondisi3 > 0 ? true : false;
		kondisi4 = tempKondisi4 > 0 ? true : false;
		kondisi5 = tempKondisi5 > 0 ? true : false;
//		Debug.Log (kondisi2);

	}

	public void SaveData(){
		//Debug.Log ("SAVE");

		if (kondisi2 == true) {
			PlayerPrefs.SetInt ("maps2", 1);
			//Debug.Log(PlayerPrefs.GetInt ("maps2"));
		} else if (kondisi2 == false) {
			PlayerPrefs.SetInt ("maps2", 0);
			//Debug.Log(PlayerPrefs.GetInt ("maps2"));

		}


		if (kondisi3 == true) {
			PlayerPrefs.SetInt ("maps3", 1);
		} else {
			PlayerPrefs.SetInt ("maps3", 0);
		}

		if (kondisi4 == true) {
			PlayerPrefs.SetInt ("maps4", 1);
		} else {
			PlayerPrefs.SetInt ("maps4", 0);
		}

		if (kondisi5 == true) {
			PlayerPrefs.SetInt ("maps5", 1);
		} else {
			PlayerPrefs.SetInt ("maps5", 0);
		}


//		if (kondisi3 == true) {
//			kon3 = 1;
//		}
//		if (kondisi4 == true) {
//			kon4 = 1;
//		}
//		if (kondisi5 == true) {
//			kon5 = 1;
//		}


//		PlayerPrefs.SetInt ("maps2", kon2 == 1 ? 1 : 0);
//		PlayerPrefs.SetInt ("maps3", kon3 == 1 ? 1 : 0);
//		PlayerPrefs.SetInt ("maps4", kon4 == 1 ? 1 : 0);
//		PlayerPrefs.SetInt ("maps5", kon5 == 1 ? 1 : 0);

	}

}
