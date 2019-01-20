using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public int health = 100;

    public Transform player = null;
    public GameObject cannonball = null;

    public float minDelay = 1.0f;
    public float maxDeplay = 4.0f;

    private float lastTime = 0.0f;
    private float delayTime = 0.0f;

	// Update is called once per frame
	void Update () {
        FollowPlayer();
        Shoot();
	}

    void FollowPlayer()
    {
        this.transform.LookAt(player);
    }

    void Shoot()
    {
        if(Time.time > lastTime + delayTime)
        {
            lastTime = Time.time;

            delayTime = GetRandomValue() * 3;

            GameObject obj = Instantiate(cannonball, this.transform.position, this.transform.rotation) as GameObject;

            obj.name = "cannonball";
        }
    }

    float GetRandomValue ()
    {
        return Random.Range(minDelay, maxDeplay);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "herobullet")
        {
            int hp = collision.gameObject.GetComponent<MagicOrb>().hitpoint;
            GetHealth(hp);
        }
    }

    void GetHealth(int hp)
    {
        if(health > 0)
        {
            health -= hp;
            Debug.Log("Turret Health:  " + health);
        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("GAME OVER");
        }
    }
}
