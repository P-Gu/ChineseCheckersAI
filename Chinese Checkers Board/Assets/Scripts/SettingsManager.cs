using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
	public void setGameMode(string gameMode){
		PlayerPrefs.SetString ("Mode", gameMode);
	}

}
