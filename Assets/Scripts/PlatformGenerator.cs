using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {


    public GameObject theLaser;
    public Transform generationPoint;
    public float distanceBetween;

    private float laserWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    
    private int laserSelector;

    public ObjectPooler[] theObjectPools;

    // Use this for initialization
    void Start () {
        
        laserWidth = theLaser.GetComponent<BoxCollider2D>().size.y;

	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y > generationPoint.position.y)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            laserSelector = Random.Range(0, theObjectPools.Length);

            transform.position = new Vector3(transform.position.x, transform.position.y - laserWidth - distanceBetween, transform.position.z);

            
                
            GameObject newLaser = theObjectPools[laserSelector].GetPooledObject();

            newLaser.transform.position = transform.position;
            newLaser.transform.rotation = transform.rotation;
            newLaser.SetActive(true);
        }

	}
}
