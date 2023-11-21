using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessCameraController : MonoBehaviour {

    public EndlessPlayerController theEndlessPlayer;
    

    private Vector3 lastPlayerPos;
    private float distanceToMove;



    // Use this for initialization
    void Start()
    {
        theEndlessPlayer = FindObjectOfType<EndlessPlayerController>();
        lastPlayerPos = theEndlessPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        distanceToMove = theEndlessPlayer.transform.position.y - lastPlayerPos.y;

        transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

        lastPlayerPos = theEndlessPlayer.transform.position;
        

        /*if (screenShakeAmount > 0)
        {
            screenShakeActive = new Vector3(Random.Range(-screenShakeAmount, screenShakeAmount), Random.Range(-screenShakeAmount, screenShakeAmount), 0f);
            screenShakeAmount -= Time.deltaTime * screenShakeDecay;
        }
        else
        {
            screenShakeActive = Vector3.zero;
        }

        transform.position += screenShakeActive;*/
    }

    /*public void ScreenShake(float toShake)
    {
        screenShakeAmount = toShake;
    }*/

}
