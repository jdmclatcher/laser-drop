using UnityEngine;
using System.Collections;

public class PlayerGuideController : MonoBehaviour {

    public GameObject blueSprite;
    public GameObject greenSprite;
    public GameObject yellowSprite;

	// Use this for initialization
	void Start () {

        blueSprite.SetActive(false);
        greenSprite.SetActive(false);
        yellowSprite.SetActive(false);
    }

    public void SetBlue()
    {
        blueSprite.SetActive(true);
        greenSprite.SetActive(false);
        yellowSprite.SetActive(false);
    }

    public void SetGreen()
    {
        blueSprite.SetActive(false);
        greenSprite.SetActive(true);
        yellowSprite.SetActive(false);
    }

    public void SetYellow()
    {
        blueSprite.SetActive(false);
        greenSprite.SetActive(false);
        yellowSprite.SetActive(true);
    }
}
