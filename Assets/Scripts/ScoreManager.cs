using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    /*public Transform laserGenerator;

    private PlatformDestroyer[] laserList;
    public Transform playerStartPos;

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    public Text endScoreText;
    public float endScoreCount;

    public PlayerController thePlayer;

    public GameObject laserGeneratorThing;

    public GameObject laserDeathParticle;

    //public GameObject hiScoreMarker;

    public GameObject theRestartScreen;

    // Use this for initialization
    void Start () {
        laserGeneratorThing.SetActive(true);
        thePlayer = FindObjectOfType<PlayerController>();
        theRestartScreen.SetActive(false);
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
	}
	
	// Update is called once per frame
	void Update () {

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

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round (highScoreCount);
	}

    public void RestartGame()
    {
        //endTimeText.text = "" + Mathf.Round(secondsToWin);

        //secondsToWin = secondsToWinStore;

        thePlayer.gameObject.SetActive(false);

        laserList = FindObjectsOfType<PlatformDestroyer>();

        theRestartScreen.gameObject.SetActive(true);

        for (int i = 0; i < laserList.Length; i++)
        {
            laserList[i].gameObject.SetActive(false);
        }


    }*/

}
