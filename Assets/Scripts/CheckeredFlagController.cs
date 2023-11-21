using UnityEngine;
using System.Collections;

public class CheckeredFlagController : MonoBehaviour {

    public string levelTag;

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
          
            PlayerPrefs.SetInt(levelTag, 1);
        }
    }
}
