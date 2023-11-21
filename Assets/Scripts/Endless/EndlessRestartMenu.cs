using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class EndlessRestartMenu : MonoBehaviour {

    public string mainMenu;
    public string levelToLoad;
    public string levelSelect;

    public EndlessGameManager theEndlessGameManager;


    

    // Use this for initialization
    void Start()
    {
        

        theEndlessGameManager = FindObjectOfType<EndlessGameManager>();


    }

    // Update is called once per frame
    void Update()
    {


    }

    public void LoadLevelOne()
    {
        

        
            theEndlessGameManager.scoreCount = theEndlessGameManager.scoreCountStore;
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
