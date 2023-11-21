using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessUnlocker : MonoBehaviour {

    public string endlessLevelTag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Gives the player the unlock key for endless level
            PlayerPrefs.SetInt(endlessLevelTag, 1);
        }
    }
}
