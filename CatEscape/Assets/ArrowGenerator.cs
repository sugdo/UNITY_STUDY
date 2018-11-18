using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    float span = 0.4f;
    float delta = 0;
    int arrow_num=0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-8, 9);
            go.transform.position = new Vector3(px, 7, 0);
            arrow_num++;

            if (arrow_num > 20)
            {
                span -= 0.03f;
                arrow_num = 0;
            }
        }
	}
}
