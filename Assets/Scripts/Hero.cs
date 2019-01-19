using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float rotateSpeed = 5.0f;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    void Move()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(0, 0, move * Time.deltaTime);
        this.transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
