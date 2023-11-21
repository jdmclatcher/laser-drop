using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class ChallengeLevelSelectController : MonoBehaviour {

    public bool adsReady;
    public bool adPlayed;
    static int loadCount = 0;

    public string levelSelect;

    public string[] challengeLevelTags;

    public GameObject[] challengeLocks;
    public bool[] challengeLevelUnlocked;

    public string challenge1;
    public GameObject challenge1Lock;
    public string challenge2;
    public GameObject challenge2Lock;
    public string challenge3;
    public GameObject challenge3Lock;
    public string challenge4;
    public GameObject challenge4Lock;
    public string challenge5;
    public GameObject challenge5Lock;
    public string challenge6;
    public GameObject challenge6Lock;
    public string challenge7;
    public GameObject challenge7Lock;
    public string challenge8;
    public GameObject challenge8Lock;
    public string challenge9;
    public GameObject challenge9Lock;
    public string challenge10;
    public GameObject challenge10Lock;
    public string challenge11;
    public GameObject challenge11Lock;
    public string challenge12;
    public GameObject challenge12Lock;
    public string challenge13;
    public GameObject challenge13Lock;
    public string challenge14;
    public GameObject challenge14Lock;
    public string challenge15;
    public GameObject challenge15Lock;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1f;

        loadCount++;

        for (int i = 0; i < challengeLevelTags.Length; i++)
        {
            if (PlayerPrefs.GetInt(challengeLevelTags[i]) == null)
            {
                challengeLevelUnlocked[i] = false;
            }
            else if (PlayerPrefs.GetInt(challengeLevelTags[i]) == 0)
            {
                challengeLevelUnlocked[i] = false;
            }
            else
            {
                challengeLevelUnlocked[i] = true;
            }

            if (challengeLevelUnlocked[i])
            {
                challengeLocks[i].SetActive(false);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (loadCount % 5 == 0)
        {
            adsReady = true;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            BackToLevelSelect();
        }
    }

    public void BackToLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void LoadChallenge1()
    {
        if (!challenge1Lock.activeInHierarchy)
        {
            if(adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }

            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge1);
            }
        }
    }

    public void LoadChallenge2()
    {
        if (!challenge2Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge2);
            }
        }
    }

    public void LoadChallenge3()
    {
        if (!challenge3Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge3);
            }
        }
    }

    public void LoadChallenge4()
    {
        if (!challenge4Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge4);
            }
        }
    }

    public void LoadChallenge5()
    {
        if (!challenge5Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge5);
            }
        }
    }

    public void LoadChallenge6()
    {
        if (!challenge6Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge6);
            }
        }
    }

    public void LoadChallenge7()
    {
        if (!challenge7Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge7);
            }
        }
    }

    public void LoadChallenge8()
    {
        if (!challenge8Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge8);
            }
        }
    }

    public void LoadChallenge9()
    {
        if (!challenge9Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge9);
            }
        }
    }

    public void LoadChallenge10()
    {
        if (!challenge10Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge10);
            }
        }
    }

    public void LoadChallenge11()
    {
        if (!challenge11Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge11);
            }
        }
    }

    public void LoadChallenge12()
    {
        if (!challenge12Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge12);
            }
        }
    }

    public void LoadChallenge13()
    {
        if (!challenge13Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge13);
            }
        }
    }

    public void LoadChallenge14()
    {
        if (!challenge14Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge14);
            }
        }
    }

    public void LoadChallenge15()
    {
        if (!challenge15Lock.activeInHierarchy)
        {
            if (adsReady && !adPlayed)
            {
                ShowAd();
                adPlayed = true;
            }
            if (!Advertisement.isShowing)
            {
                SceneManager.LoadScene(challenge15);
            }
        }
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
