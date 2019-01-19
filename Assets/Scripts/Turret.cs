using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public Transform player = null;
    public GameObject cannonball = null;

    public float minDelay = 1.0f;
    public float delayTime = 0.0f;

    private float lastTime = 0.0f;
    private float delayTime = 0.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FollowPlayer();
	}

    void FollowPlayer()
    {
        this.transform.LookAt(player);
    }
}
