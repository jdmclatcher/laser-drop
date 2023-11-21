using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Transform laserGenerator;


    public PlayerController thePlayer;


    private PlatformDestroyer[] laserList;
    public Transform playerStartPos;



    public GameObject theRestartScreen;


    public float secondsToWin;
    public float secondsToWinStore;

    public GameObject levelCompleteScreen;
    public Text secondsToWinText;

    public bool timeDecreasing;

    public Text endTimeText;

    public GameObject theCheckeredFlag;

    public GameObject checkeredFlagEffect;

    public bool flagsUp;

    public GameObject laserGeneratorThing;

    public GameObject laserDeathParticle;

    public GameObject hiScoreMarker;

   
	// Use this for initialization
	void Start () {
        laserGeneratorThing.SetActive(true);
        flagsUp = false;
        theCheckeredFlag.SetActive(false);
        timeDecreasing = true;
        levelCompleteScreen.SetActive(false);
        theRestartScreen.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {

        secondsToWin -= Time.deltaTime;
       
        

        if (theRestartScreen.activeInHierarchy)
        {
            secondsToWin = secondsToWinStore;
            timeDecreasing = false;
        }

        if (secondsToWin <= 0f)
        {
            secondsToWin = 0f;
            secondsToWinText.text = "0.0";
        }

        if (secondsToWin <= 0f && thePlayer.isLasered == false)
        {
            theCheckeredFlag.SetActive(true);
            Instantiate(checkeredFlagEffect, theCheckeredFlag.transform.position, theCheckeredFlag.transform.rotation);
            theCheckeredFlag.transform.parent = null;
            laserGeneratorThing.SetActive(false);

            laserList = FindObjectsOfType<PlatformDestroyer>();

            for (int i = 0; i < laserList.Length; i++)
            {
                laserList[i].gameObject.SetActive(false);
                Instantiate(laserDeathParticle, laserList[i].gameObject.transform.position, laserList[i].gameObject.transform.rotation);
            }

            timeDecreasing = false;
            flagsUp = true;

        }


        if (thePlayer.isCheckered)
        {
            timeDecreasing = false;
            EndLevel();
            
            
        }


        if (timeDecreasing == false)
        {
            secondsToWin = secondsToWinStore;
        }

        if (timeDecreasing == true)
        {
            secondsToWinText.text = "" + Mathf.Round(secondsToWin);
        }

        if (secondsToWin <= 10f)
        {
            secondsToWinText.text = "" + Mathf.Round(secondsToWin * 10f) / 10f;
        }

       
	}

    public void EndLevel()
    {
        levelCompleteScreen.SetActive(true);
        secondsToWin = secondsToWinStore;
        secondsToWinText.text = "0.0";
        thePlayer.moveSpeed = 0f;

        

    }


    public void RestartGame()
    {
        if (secondsToWin < 10)
        {
            endTimeText.text = "" + Mathf.Round((secondsToWin) * 10) / 10;
        }
        else {
            endTimeText.text = "" + Mathf.Round(secondsToWin);
        }    

        secondsToWin = secondsToWinStore;

        thePlayer.gameObject.SetActive(false);

        laserList = FindObjectsOfType<PlatformDestroyer>();

        theRestartScreen.gameObject.SetActive(true);

        for (int i = 0; i < laserList.Length; i++)
        {
            laserList[i].gameObject.SetActive(false);
        }

       
    }

    
}
