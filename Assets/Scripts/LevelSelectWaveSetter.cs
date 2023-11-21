using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectWaveSetter : MonoBehaviour {

    public string whichIsDefaultWave;

    public int waveValueToSet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt(whichIsDefaultWave, waveValueToSet);
        }
    }
}
