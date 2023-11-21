using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

    private PlayerController thePlayer;

    private PauseMenu thePauseMenu;

    

	// Use this for initialization
	void Start () {

        thePlayer = FindObjectOfType<PlayerController>();

        thePauseMenu = FindObjectOfType<PauseMenu>();
	}

   

    public void setSpriteBlue()
    {
        
        thePlayer.setBlue();
       

    }

    public void setSpriteGreen()
    {
       
            thePlayer.setGreen();
        
    }

    public void setSpriteYellow()
    {
        
            thePlayer.setYellow();
        
    }

    public void setSpriteRed()
    {
        
            thePlayer.setRed();
        
    }

    public void PauseGame()
    {
        thePauseMenu.PauseUnpause();
    }

	
}
