using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class EndlessPlayerController : MonoBehaviour {

    public float moveSpeed;
    public float speedAddition;
    private float moveSpeedStore;
    

    public float speedIncreaseMilestone;
    public float speedIncreaseMilestoneAddition;
 

    public float speedMilestoneCount;
    

    private Rigidbody2D myRigidbody;
    private SpriteRenderer mySpriteRenderer;
 
    public EndlessGameManager theEndlessGameManager;

    public LayerMask whatIsLaser;
    public Transform groundCheck;
    public float groundCheckRadius;

   

    public Sprite whiteSprite;
    public Sprite blueSprite;
    public Sprite greenSprite;
    public Sprite yellowSprite;
    public Sprite redSprite;
  

    public GameObject theTouchControls;


    public bool isLasered;

    public bool switchedColors;

    public Animator theAnimator;
    public string theSwitchAnimationClip;

    public GameObject blueParticle;
    public GameObject yellowParticle;
    public GameObject greenParticle;
    public GameObject redParticle;
    public GameObject deathParticle;
    public GameObject lifeParticle;

  

    public AudioSource deathSound;
    public AudioSource switchSound;
    public AudioSource passThruSound;


    public bool isMuted;

    public bool adPlayed;
    static int loadCount = 0;


    // Use this for initialization
    void Start()
    {
        isLasered = false;

        switchedColors = false;

        

        theAnimator = GetComponent<Animator>();


        Instantiate(lifeParticle, transform.position, transform.rotation);

        myRigidbody = GetComponent<Rigidbody2D>();

        mySpriteRenderer = GetComponent<SpriteRenderer>();

        theEndlessGameManager = FindObjectOfType<EndlessGameManager>();



        moveSpeedStore = moveSpeed;


        loadCount++;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (transform.position.y < speedIncreaseMilestone)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            //adds desired value to the the milestone
            speedIncreaseMilestone = speedIncreaseMilestone + speedIncreaseMilestoneAddition;

            //adds desired value to moveSpeed
            moveSpeed = moveSpeed + speedAddition;
        }

        

        if (PlayerPrefs.GetInt("Volume") == 0)
        {
            isMuted = false;
        }
        else
        {
            isMuted = true;
        }


        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -moveSpeed);



    }

    public void setBlue()
    {

        if (mySpriteRenderer.sprite == blueSprite)
        {
            Debug.Log("You're already blue, fool.");
            switchedColors = false;
        }
        else
        {
            if (!isMuted)
            {
                switchSound.Play();
            }
            theAnimator.Play(theSwitchAnimationClip);
            switchedColors = true;
            mySpriteRenderer.sprite = blueSprite;
            
        }

    }

    public void setGreen()
    {

        if (mySpriteRenderer.sprite == greenSprite)
        {
            Debug.Log("You're already green, fool.");
            switchedColors = false;
        }
        else
        {
            if (!isMuted)
            {
                switchSound.Play();
            }
            theAnimator.Play(theSwitchAnimationClip);
            switchedColors = true;
            mySpriteRenderer.sprite = greenSprite;
 
        }
    }
    public void setYellow()
    {
        if (mySpriteRenderer.sprite == yellowSprite)
        {
            Debug.Log("You're already yellow, fool.");
            switchedColors = false;
        }
        else
        {
            if (!isMuted)
            {
                switchSound.Play();
            }
            theAnimator.Play(theSwitchAnimationClip);
            switchedColors = true;
            mySpriteRenderer.sprite = yellowSprite;
   
        }
    }

    public void setRed()
    {
        if (mySpriteRenderer.sprite == redSprite)
        {
            Debug.Log("You're already red, fool.");
            switchedColors = false;
        }
        else
        {
            if (!isMuted)
            {
                switchSound.Play();
            }
            switchedColors = true;
            mySpriteRenderer.sprite = redSprite;
   
        }
    }

    
    public void killPlayer()
    {
        if (loadCount % 4 == 0 && !adPlayed)
        {
            Advertisement.Show();
            adPlayed = true;
        }

        if (!isMuted)
        {
            deathSound.Play();
        }


       
        theEndlessGameManager.RestartGame();
        mySpriteRenderer.sprite = whiteSprite;
        moveSpeed = moveSpeedStore;



        
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "greenLaser" && mySpriteRenderer.sprite == greenSprite)
        {
            Instantiate(greenParticle, transform.position, transform.rotation);
            isLasered = true;
            if (!isMuted)
            {
                passThruSound.Play();
            }

        }
        else if (other.tag == "yellowLaser" && mySpriteRenderer.sprite == yellowSprite)
        {
            Instantiate(yellowParticle, transform.position, transform.rotation);
            isLasered = true;
            if (!isMuted)
            {
                passThruSound.Play();
            }
        }
        else if (other.tag == "blueLaser" && mySpriteRenderer.sprite == blueSprite)
        {
            Instantiate(blueParticle, transform.position, transform.rotation);
            isLasered = true;
            if (!isMuted)
            {
                passThruSound.Play();
            }
        }
        else if (other.tag == "redLaser" && mySpriteRenderer.sprite == redSprite)
        {
            Instantiate(redParticle, transform.position, transform.rotation);
            isLasered = true;
            if (!isMuted)
            {
                passThruSound.Play();
            }
        }

        
        else
        {
            Instantiate(deathParticle, transform.position, transform.rotation);
            killPlayer();
            isLasered = false;
         
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if ((other.tag == "greenLaser" || other.tag == "blueLaser" || other.tag == "yellowLaser" || other.tag == "redLaser"))
        {
            theAnimator.Play(theSwitchAnimationClip);
            mySpriteRenderer.sprite = whiteSprite;
            isLasered = false;
        }
    }
}
