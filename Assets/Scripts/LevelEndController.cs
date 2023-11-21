using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndController : MonoBehaviour {

    public string mainMenu;
    public string levelSelect;
    public string credits;



    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(credits);
    }
}
