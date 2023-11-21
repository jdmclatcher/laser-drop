using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessPauseMenu : MonoBehaviour {

    public string mainMenu;
    public string levelSelect;

    public bool isPaused;

    private EndlessGameManager theEndlessGameManager;

    public GameObject pauseMenuCanvas;

    public AudioSource clickSound;

    public EndlessPlayerController theEndlessPlayer;

    public string levelChallengeUnlock;



    public bool canPause;

    void Start()
    {
        theEndlessPlayer = FindObjectOfType<EndlessPlayerController>();
        theEndlessGameManager = FindObjectOfType<EndlessGameManager>();

        canPause = true;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isPaused && canPause)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            isPaused = !isPaused;
        }
    }

    public void PauseUnpause()
    {
        if (!theEndlessPlayer.isMuted)
        {
            clickSound.Play();
        }

        isPaused = !isPaused;
    }

    public void Resume()
    {
        if (!theEndlessPlayer.isMuted)
        {
            clickSound.Play();
        }

        isPaused = false;
    }

    public void MainMenu()
    {
        if (theEndlessGameManager.highScoreCount >= 100f)
        {
            
            PlayerPrefs.SetInt(levelChallengeUnlock, 1);
        }

        SceneManager.LoadScene(mainMenu);
    }

    public void LoadLevelSelect()
    {
        if (theEndlessGameManager.highScoreCount >= 100f)
        {

            PlayerPrefs.SetInt(levelChallengeUnlock, 1);
        }

        SceneManager.LoadScene(levelSelect);
    }

   
}
