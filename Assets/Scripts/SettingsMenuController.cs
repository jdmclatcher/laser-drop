using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SettingsMenuController : MonoBehaviour {

    public string mainMenu;

    public string creditsMenu;

    

	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.Escape))
        {
            GoBack();
        }
	}

    public void GoBack()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void RollCredits()
    {
        SceneManager.LoadScene(creditsMenu);
    }


    //changes int value by one, 0 = sound on, 1 = muted
    
}
