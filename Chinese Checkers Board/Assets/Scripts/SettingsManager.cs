using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
{
	public GameObject button;

	public bool isManager=false;

	public string toggleText;
	public bool rotate = true;
	public bool target = false;
	public bool sfx = true;

	public void Start(){
		if (isManager) {
			GameObject.Find ("Main Screen").gameObject.SetActive (true);
			GameObject.Find ("Settings Screen").gameObject.SetActive (false);
			GameObject.Find ("Mode Select Screen").gameObject.SetActive (false);
			GameObject.Find ("Credits Screen").gameObject.SetActive (false);
		}
	}

	public void setGameMode(string gameMode){
		PlayerPrefs.SetString ("Mode", gameMode);
	}

	public void toggleCamera(){
		if (rotate) {
			PlayerPrefs.SetInt ("CamRotate", 1);
			toggleText="On";
			Debug.Log("Rotate is ON");
			rotate = false;
		} else {
			PlayerPrefs.SetInt ("CamRotate", 0);
			toggleText = "Off";
			Debug.Log("Rotate is OFF");
			rotate = true;
		}

		button.GetComponentInChildren<Text>().text = toggleText;

	}

	public void toggleTarget(){
		if (target) {
			PlayerPrefs.SetInt ("Target", 1);
			toggleText="On";
			Debug.Log("Target is ON");
			target = false;
		} else {
			PlayerPrefs.SetInt ("Target", 0);
			toggleText = "Off";
			Debug.Log("Target is OFF");
			target = true;
		}

		button.GetComponentInChildren<Text>().text = toggleText;

	}

	public void toggleSFX(){
		if (sfx) {
			PlayerPrefs.SetInt ("SFX", 1);
			toggleText="On";
			Debug.Log("SFX are ON");
			sfx = false;
		} else {
			PlayerPrefs.SetInt ("SFX", 0);
			toggleText = "Off";
			Debug.Log("SFX are OFF");
			sfx = true;
		}

		button.GetComponentInChildren<Text>().text = toggleText;

	}


}
