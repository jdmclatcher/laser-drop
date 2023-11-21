using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;
    public GameManager theGameManager;

    private Vector3 screenShakeActive;

    private float screenShakeAmount;

    //public float screenShakeDecay;

    private Vector3 lastPlayerPos;
    private float distanceToMove;

    public bool isMoving;

    

	// Use this for initialization
	void Start () {
        isMoving = true;
        theGameManager = FindObjectOfType<GameManager>();
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPos = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        if (theGameManager.flagsUp)
        {
            isMoving = false;
            
        }

        if (!isMoving)
        {
            distanceToMove = 0f;
        }

        if (isMoving)
        {
            distanceToMove = thePlayer.transform.position.y - lastPlayerPos.y;

            transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

            lastPlayerPos = thePlayer.transform.position;
        }

        
	}

    
    
}
