using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public string mainMenu;
    public string levelSelect;

    public bool isPaused;

    private GameManager theGameManager;

    public GameObject pauseMenuCanvas;

    public AudioSource clickSound;

    public PlayerController thePlayer;

   
    public bool canPause;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theGameManager = FindObjectOfType<GameManager>();
        
    }

	// Update is called once per frame
	void Update () {
        if (theGameManager.levelCompleteScreen.activeInHierarchy || theGameManager.theRestartScreen.activeInHierarchy)
        {
            canPause = false;
        }
        else {
            canPause = true;
        }

        if (isPaused && canPause)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else {
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
        if (!thePlayer.isMuted)
        {
            clickSound.Play();
        }
        
        isPaused = !isPaused;
    }

    public void Resume()
    {
        if (!thePlayer.isMuted)
        {
            clickSound.Play();
        }

        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);       
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    
}
