using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class LevelMenuController : MonoBehaviour {

    public bool adsReady;
    public bool adPlayed;
    static int loadCount = 0;

    public AudioSource clickSound;

    public string mainMenu;

    public GameObject firstWave;
    public GameObject secondWave;
    public GameObject thirdWave;
    public GameObject fourthWave;

    public string[] levelTags;

    public GameObject[] locks;
    public bool[] levelUnlocked;

    public GameObject errorScreen;
    public GameObject challengeErrorScreen;

    public GameObject endlessLockShade;

    public string endlessLevelTag;

    public GameObject endlessUnlockerAnimObject;
   

    public GameObject challengeLockShade;

    public string challengeLevelTag;

    public string challengeLevel1Tag;

    public GameObject challengeUnlockerAnimObject;

    public string endless;
    public string challengeLevelSelect;
    public string level1;
    public GameObject level1Lock;
    public string level2;
    public GameObject level2Lock;
    public string level3;
    public GameObject level3Lock;
    public string level4;
    public GameObject level4Lock;
    public string level5;
    public GameObject level5Lock;
    public string level6;
    public GameObject level6Lock;
    public string level7;
    public GameObject level7Lock;
    public string level8;
    public GameObject level8Lock;
    public string level9;
    public GameObject level9Lock;
    public string level10;
    public GameObject level10Lock;
    public string level11;
    public GameObject level11Lock;
    public string level12;
    public GameObject level12Lock;
    public string level13;
    public GameObject level13Lock;
    public string level14;
    public GameObject level14Lock;
    public string level15;
    public GameObject level15Lock;
    public string level16;
    public GameObject level16Lock;
    public string level17;
    public GameObject level17Lock;
    public string level18;
    public GameObject level18Lock;
    public string level19;
    public GameObject level19Lock;
    public string level20;
    public GameObject level20Lock;
    public string level21;
    public GameObject level21Lock;
    public string level22;
    public GameObject level22Lock;
    public string level23;
    public GameObject level23Lock;
    public string level24;
    public GameObject level24Lock;
    public string level25;
    public GameObject level25Lock;
    public string level26;
    public GameObject level26Lock;
    public string level27;
    public GameObject level27Lock;
    public string level28;
    public GameObject level28Lock;
    public string level29;
    public GameObject level29Lock;
    public string level30;
    public GameObject level30Lock;
    public string level31;
    public GameObject level31Lock;
    public string level32;
    public GameObject level32Lock;
    public string level33;
    public GameObject level33Lock;
    public string level34;
    public GameObject level34Lock;
    public string level35;
    public GameObject level35Lock;
    public string level36;
    public GameObject level36Lock;


    //1 is First Wave, 2 is Second Wave, 3 is Third Wave, and 4 is Fourth Wave
    public string whichIsDefaultWave;


    // Use this for initialization
    void Start() {

        if (PlayerPrefs.GetInt(whichIsDefaultWave) == 1)
        {
            ActivateFirst();
        }

        else if (PlayerPrefs.GetInt(whichIsDefaultWave) == 2)
        {
            ActivateSecond();
        }

        else if (PlayerPrefs.GetInt(whichIsDefaultWave) == 3)
        {
            ActivateThird();
        }

        else if (PlayerPrefs.GetInt(whichIsDefaultWave) == 4)
        {
            ActivateFourth();
        }

        else {
            ActivateFirst();
        }


        if (PlayerPrefs.GetInt(endlessLevelTag) == 1 && PlayerPrefs.GetInt("SeenEndlessUnlock") != 1)
        {
            
            endlessUnlockerAnimObject.SetActive(true);
            //1 means has been seen
            PlayerPrefs.SetInt("SeenEndlessUnlock", 1);
        }

        

        if (PlayerPrefs.GetInt(challengeLevelTag) == 1 && PlayerPrefs.GetInt("SeenChallengeUnlock") != 1)
        {
            challengeUnlockerAnimObject.SetActive(true);
            PlayerPrefs.SetInt("SeenChallengeUnlock", 1);
        }

        

        errorScreen.SetActive(false);

        challengeErrorScreen.SetActive(false);

        loadCount++;

       

        Time.timeScale = 1f;

        for (int i = 0; i < levelTags.Length; i++)
        {
            if (PlayerPrefs.GetInt(levelTags[i]) == null)
            {
                levelUnlocked[i] = false;
            }
            else if (PlayerPrefs.GetInt(levelTags[i]) == 0)
            {
                levelUnlocked[i] = false;
            } else
            {
                levelUnlocked[i] = true;
            }

            if (levelUnlocked[i])
            {
                locks[i].SetActive(false);
            }
        }


    }

    // Update is called once per frame
    void Update() {

        if (PlayerPrefs.GetInt(endlessLevelTag) == 1)
        {
            endlessLockShade.SetActive(false);
        }
        else
        {
            endlessLockShade.SetActive(true);
        }

        if (PlayerPrefs.GetInt(challengeLevelTag) == 1)
        {
            challengeLockShade.SetActive(false);
        }

        else {
            challengeLockShade.SetActive(true);
        }

        if (loadCount % 5 == 0)
        {
            adsReady = true;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            GoBackToMenu();
        }
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void LoadEndless()
    {
        if (PlayerPrefs.GetInt(endlessLevelTag) == 1)
        {
            SceneManager.LoadScene(endless);
        }
        else
        {
            if (!challengeErrorScreen.activeInHierarchy)
            {
                errorScreen.SetActive(true);
            }
        }
    }

    public void LoadChallenge()
    {
        if (PlayerPrefs.GetInt(challengeLevelTag) == 1)
        {
            PlayerPrefs.SetInt(challengeLevel1Tag, 1);
            SceneManager.LoadScene(challengeLevelSelect);
        }
        else
        {
            if (!errorScreen.activeInHierarchy)
            {
                challengeErrorScreen.SetActive(true);

            }

        }
    }

    public void LoadLevel1()
    {
        if (!level1Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                
                SceneManager.LoadScene(level1);
            }

        }

    }

    public void LoadLevel2()
    {
        if (!level2Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level2);
            }

        }
    }

    public void LoadLevel3()
    {
        if (!level3Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level3);
            }

        }
    }

    public void LoadLevel4()
    {
        if (!level4Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level4);
            }

        }
    }

    public void LoadLevel5()
    {
        if (!level5Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level5);
            }

        }
    }

    public void LoadLevel6()
    {
        if (!level6Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level6);
            }

        }
    }

    public void LoadLevel7()
    {
        if (!level7Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level7);
            }

        }
    }

    public void LoadLevel8()
    {
        if (!level8Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level8);
            }

        }
    }

    public void LoadLevel9()
    {
        if (!level9Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {            
                SceneManager.LoadScene(level9);
            }

        }
    }

    public void LoadLevel10()
    {
        if (!level10Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level10);
            }

        }
    }

    public void LoadLevel11()
    {
        if (!level11Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {                
                SceneManager.LoadScene(level11);
            }
        }
    }

    public void LoadLevel12()
    {
        if (!level12Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level12);              
            }
        }
    }

    public void LoadLevel13()
    {
        if (!level13Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level13);
            }
        }
    }

    public void LoadLevel14()
    {
        if (!level14Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level14);
            }
        }
    }

    public void LoadLevel15()
    {
        if (!level15Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level15);
            }
        }
    }

    public void LoadLevel16()
    {
        if (!level16Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level16);
            }
        }
    }

    public void LoadLevel17()
    {
        if (!level17Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level17);
            }
        }
    }

    public void LoadLevel18()
    {
        if (!level18Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level18);
            }
        }
    }

    public void LoadLevel19()
    {
        if (!level19Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level19);
            }
        }
    }

    public void LoadLevel20()
    {
        if (!level20Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level20);
            }
        }
    }

    public void LoadLevel21()
    {
        if (!level21Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level21);
            }
        }
    }

    public void LoadLevel22()
    {
        if (!level22Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level22);
            }
        }
    }

    public void LoadLevel23()
    {
        if (!level23Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level23);
            }
        }
    }

    public void LoadLevel24()
    {
        if (!level24Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level24);
            }
        }
    }

    public void LoadLevel25()
    {
        if (!level25Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level25);
            }
        }
    }

    public void LoadLevel26()
    {
        if (!level26Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level26);
            }
        }
    }

    public void LoadLevel27()
    {
        if (!level27Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level27);
            }
        }
    }

    public void LoadLevel28()
    {
        if (!level28Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level28);
            }
        }
    }

    public void LoadLevel29()
    {
        if (!level29Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level29);
            }
        }
    }

    public void LoadLevel30()
    {
        if (!level30Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level30);
            }
        }
    }

    public void LoadLevel31()
    {
        if (!level31Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level31);
            }
        }
    }

    public void LoadLevel32()
    {
        if (!level32Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level32);
            }
        }
    }

    public void LoadLevel33()
    {
        if (!level33Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level33);
            }
        }
    }

    public void LoadLevel34()
    {
        if (!level34Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level34);
            }
        }
    }

    public void LoadLevel35()
    {
        if (!level35Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level35);
            }
        }
    }

    public void LoadLevel36()
    {
        if (!level36Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(level36);
            }
        }
    }

    public void ActivateFirst()
    {
        if (!firstWave.activeInHierarchy)
        {
            clickSound.Play();
        }    
        firstWave.SetActive(true);
        secondWave.SetActive(false);
        thirdWave.SetActive(false);
        fourthWave.SetActive(false);
    }

    public void ActivateSecond()
    {
        if (!secondWave.activeInHierarchy)
        {
            clickSound.Play();
        }
        
        firstWave.SetActive(false);
        secondWave.SetActive(true);
        thirdWave.SetActive(false);
        fourthWave.SetActive(false);
    }

    public void ActivateThird()
    {
        if (!thirdWave.activeInHierarchy)
        {
            clickSound.Play();
        }
        
        firstWave.SetActive(false);
        secondWave.SetActive(false);
        thirdWave.SetActive(true);
        fourthWave.SetActive(false);
    }

    public void ActivateFourth()
    {
        if (!fourthWave.activeInHierarchy)
        {
            clickSound.Play();
        }
        
        firstWave.SetActive(false);
        secondWave.SetActive(false);
        thirdWave.SetActive(false);
        fourthWave.SetActive(true);
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

}
