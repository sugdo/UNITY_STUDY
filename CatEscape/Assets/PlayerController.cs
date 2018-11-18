using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float span = 165f;
    float delta = 165;

    // Use this for initialization
    void Start () {
		
	}

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(-3, 0, 0);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Translate(3, 0, 0);


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GetComponent<AudioSource>().Play();
        }



    }
}
