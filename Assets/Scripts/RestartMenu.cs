using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class RestartMenu : MonoBehaviour {

    public string mainMenu;
    public string levelToLoad;
    public string levelSelect;

    public GameManager theGameManager;
   

    

	// Use this for initialization
	void Start () {
        
        
        theGameManager = FindObjectOfType<GameManager>();

       
    }
	
	// Update is called once per frame
	void Update () {
        
        
	}

    public void LoadLevelOne()
    {
        

        
            theGameManager.secondsToWin = theGameManager.secondsToWinStore;
            SceneManager.LoadScene(levelToLoad);

        


        
    }

    


public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }
}
