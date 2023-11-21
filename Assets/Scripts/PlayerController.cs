using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float speedAddition;
    private float moveSpeedStore;
    public float secondsToSpeedUpAt;
    public bool completedSpeedAddition;

    private Rigidbody2D myRigidbody;
    private SpriteRenderer mySpriteRenderer;
    
    public GameManager theGameManager;

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
    public bool isCheckered;
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
    public AudioSource victorySound;

    public bool isMuted;

    //ads
    static int loadCount = 0;
    public bool adPlayed;


    // Use this for initialization
    void Start () {
        isLasered = false;

        switchedColors = false;

        theAnimator = GetComponent<Animator>();


        Instantiate(lifeParticle, transform.position, transform.rotation);

        myRigidbody = GetComponent<Rigidbody2D>(); 

        mySpriteRenderer = GetComponent<SpriteRenderer>();

        theGameManager = FindObjectOfType<GameManager>(); 


        moveSpeedStore = moveSpeed;

        completedSpeedAddition = false;


        loadCount++;
    }
	
	// Update is called once per frame
	void Update () {

        if (isCheckered)
        {
            mySpriteRenderer.sprite = whiteSprite;           
        }
        else
        {
            theTouchControls.SetActive(true);
        }
        

        if (theGameManager.secondsToWin <= secondsToSpeedUpAt && completedSpeedAddition == false)
        {
            moveSpeed = moveSpeed + speedAddition;

            completedSpeedAddition = true;

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
            theAnimator.Play(theSwitchAnimationClip);
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

      
       
        theGameManager.RestartGame();
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

        else if (other.tag == "checkeredFlag")
        {
            isCheckered = true;

            if (!isMuted)
            {
                victorySound.Play();
            }
        }
        else
        {
            Instantiate(deathParticle, transform.position, transform.rotation);
            killPlayer();
            isLasered = false;
            isCheckered = false;
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
