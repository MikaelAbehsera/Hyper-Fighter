using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicOrb : MonoBehaviour {

    public int hitpoint = 25;
    public float speed = 25.0f;
    public AudioClip audioHit = null;
    public AudioClip audioShoot = null;
    public ParticleSystem particle = null;

    void Awake()
    {
        //this.GetComponent<AudioSource>().PlayOneShot(audioShoot);
    }

	// Update is called once per frame
	void Update () {
        MoveObject();
	}

    void MoveObject()
    {
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        //this.GetComponent<AudioSource>().PlayOneShot(audioHit);
        this.GetComponent<Renderer>().enabled = false;
        this.GetComponent<Collider>().enabled = false;

        //Destroy(this.gameObject, audioHit.length);
        Destroy(this.gameObject);
    }
}