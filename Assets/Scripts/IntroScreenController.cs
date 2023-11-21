using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroScreenController : MonoBehaviour {

    public string firstLevel;

    public GameObject exitButton;

    public GameObject firstNextButton;


    public GameObject howToPlayText;
    public GameObject timeText;

    public GameObject firstTextBox;
    public GameObject secondTextBox;

    public GameObject doneButton;

    void Start () {     
        exitButton.SetActive(true);
        doneButton.SetActive(false);

        firstNextButton.SetActive(true);


        howToPlayText.SetActive(true);
        timeText.SetActive(false);

        firstTextBox.SetActive(true);
        secondTextBox.SetActive(false);
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            DoneWithTutorials();
        }
    }

    public void DoneWithTutorials()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void NextAndToTime()
    {
        firstNextButton.SetActive(false);


        howToPlayText.SetActive(false);
        timeText.SetActive(true);

        firstTextBox.SetActive(false);
        secondTextBox.SetActive(true);

        doneButton.SetActive(true);
    }



    
}
