using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float rotateSpeed = 5.0f;
    public int bulletAmount = 20;
    public GameObject magicOrb = null;
    public Transform socket = null;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Move();
        Shoot();
    }

    void Move()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(0, 0, move * Time.deltaTime);
        this.transform.Rotate(0, rotation * Time.deltaTime, 0);
    }

    void Shoot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(bulletAmount > 0)
            {
                bulletAmount--;
                GameObject obj = Instantiate(magicOrb, socket.position, socket.rotation) as GameObject;
                obj.name = "hero-bullet";
            }
        }
    }
}
