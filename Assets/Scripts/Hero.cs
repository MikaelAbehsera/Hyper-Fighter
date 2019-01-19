using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public float moveSpeed = 5.0f;

	// Use this for initialization
	void Start () {
        Move();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Move()
    {
        float move = Input.GetAxis("Vertical");

        this.transform.Translate(0, 0, move * Time.deltaTime);
    }
}
