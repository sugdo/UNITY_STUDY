﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player"); 
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0)
            Destroy(gameObject);

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;

        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //화살반경
        float r2 = 0.8f; //플레이어 반경

        if(d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }
	}
}
