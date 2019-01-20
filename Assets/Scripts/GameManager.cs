using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Hero hero = null;

    public Text UserHp = null;
    public Text Shots = null;

	
	// Update is called once per frame
	void Update () {
        DisplayProperties();
	}

    void DisplayProperties()
    {
        UserHp.text = "User Hp: " + hero.health.ToString();
        Shots.text = "Shots Left: " + hero.bulletAmount.ToString();

    }
}
