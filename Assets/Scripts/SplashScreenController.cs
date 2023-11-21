using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour {

    public string levelToLoad;

    public float secondsToWait;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
	}


    public void EndSplashScreen()
    {
        SceneManager.LoadScene(levelToLoad);
    }

	// Update is called once per frame
	void Update () {

        secondsToWait -= Time.deltaTime;

        if (secondsToWait <= 0)
        {
            EndSplashScreen();
        }

    }
}
