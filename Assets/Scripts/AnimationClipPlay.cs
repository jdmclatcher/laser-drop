using UnityEngine;
using System.Collections;

public class AnimationClipPlay : MonoBehaviour {

    public string theAnimationClipName;

    private Animator theAnimator;

	// Use this for initialization
	void Start () {
        theAnimator = GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {
        theAnimator.Play(theAnimationClipName);
    }
}
