using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreditsMenuController : MonoBehaviour {

    public string mainMenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            LoadSettings();
        }
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void LoadLove()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.EmpoweredPixel.LaserDrop&hl=en");
    }
    
     
}
