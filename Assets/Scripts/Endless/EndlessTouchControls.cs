using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessTouchControls : MonoBehaviour {

    private EndlessPlayerController theEndlessPlayer;

    private EndlessPauseMenu theEndlessPauseMenu;

    

    // Use this for initialization
    void Start()
    {

        theEndlessPlayer = FindObjectOfType<EndlessPlayerController>();

        theEndlessPauseMenu = FindObjectOfType<EndlessPauseMenu>();
    }



    public void setSpriteBlue()
    {

        theEndlessPlayer.setBlue();


    }

    public void setSpriteGreen()
    {

        theEndlessPlayer.setGreen();

    }

    public void setSpriteYellow()
    {

        theEndlessPlayer.setYellow();

    }

    public void setSpriteRed()
    {

        theEndlessPlayer.setRed();

    }

    public void PauseGame()
    {
        theEndlessPauseMenu.PauseUnpause();
    }

}
