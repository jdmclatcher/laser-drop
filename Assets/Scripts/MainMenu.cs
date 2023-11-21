using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string levelToLoad;
    
    public string help;
    public string credits;

    public string level1Tag;

    public GameObject soundOn;
    public GameObject soundOff;

    public AudioSource clickSound;

    //Get rid of this at end
    public string endlessLevelTag;
    public string challengeLevelTag;

   

    void Start()
    {
        if (PlayerPrefs.GetInt("Volume") == 0)
        {
            PlayerPrefs.SetInt("Volume", 0);
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            PlayerPrefs.SetInt("Volume", 1);
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }

        Time.timeScale = 1f;
        
    }

    public void StartGame()
    {

        PlayerPrefs.SetInt(level1Tag, 1);

        SceneManager.LoadScene(levelToLoad);
    }

   

    public void LoadHelp()
    { 
        PlayerPrefs.SetInt(level1Tag, 1);
        SceneManager.LoadScene(help);
    }

    public void RollCredits()
    {
        

        PlayerPrefs.SetInt(level1Tag, 1);
        SceneManager.LoadScene(credits);
    }

    public void SetVolume()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            clickSound.Play();
            soundOn.SetActive(true);
            soundOff.SetActive(false);
            PlayerPrefs.SetInt("Volume", 0);

        }
        else
        {
            
            soundOff.SetActive(true);
            soundOn.SetActive(false);
            PlayerPrefs.SetInt("Volume", 1);

        }

    }

}
