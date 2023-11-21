using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour {

    public string mainMenu;
    public string levelToLoad;
    public string levelSelect;
    public string endless;

    //public float levelNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void LoadLevelToLoad()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void LoadEndless()
    {
        SceneManager.LoadScene(endless);
    }
}
