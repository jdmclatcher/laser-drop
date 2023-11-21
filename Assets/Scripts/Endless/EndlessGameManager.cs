using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndlessGameManager : MonoBehaviour {

    public Transform laserGenerator;


    public EndlessPlayerController theEndlessPlayer;


    private PlatformDestroyer[] laserList;


 
    private EndlessCameraController theEndlessCameraController;

    public GameObject theRestartScreen;


    

    public bool timeDecreasing;

    public Text scoreText;
    public Text highScoreText;
    public Text endScoreText;
    public Text highScoreBarText;

    public float scoreCount;
    public float scoreCountStore;
    public float highScoreCount;
    public float endScoreCount;


    public float pointsPerSecond;
    public bool scoreIncreasing;

    

    public GameObject laserGeneratorThing;

    public GameObject laserDeathParticle;

    public string levelChallengeUnlock;



    // Use this for initialization
    void Start()
    {

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }

        theEndlessPlayer = FindObjectOfType<EndlessPlayerController>();
        laserGeneratorThing.SetActive(true);
  
        theRestartScreen.SetActive(false);

     
        scoreIncreasing = true;
    }

    // Update is called once per frame
    void Update()
    {

        


        if (scoreIncreasing)
        {
            endScoreCount = scoreCount;
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
        highScoreBarText.text = "High Score: " + Mathf.Round(highScoreCount);


    }

    


    public void RestartGame()
    {
        if (highScoreCount >= 100f)
        {

            PlayerPrefs.SetInt(levelChallengeUnlock, 1);

        }

        theRestartScreen.SetActive(true);

        endScoreText.text = "SCORE: " + Mathf.Round(scoreCount);

        theEndlessPlayer.gameObject.SetActive(false);

        laserList = FindObjectsOfType<PlatformDestroyer>();

        theRestartScreen.gameObject.SetActive(true);

        for (int i = 0; i < laserList.Length; i++)
        {
            laserList[i].gameObject.SetActive(false);
        }

        scoreIncreasing = false;

        


    }

   
}
