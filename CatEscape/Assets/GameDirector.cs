using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
    GameObject hpGauge;


    float span = 0f;
    GameObject Score;

    // Use this for initialization
    void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
        this.Score = GameObject.Find("Score");
	}
	
	public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {

        this.span += Time.deltaTime;

        if(span < 10) 
        this.Score.GetComponent<Text>().text = "초보자:" + span + "점";
        else if (span < 20)
            this.Score.GetComponent<Text>().text = "중수:" + span + "점";
        else if (span < 30)
            this.Score.GetComponent<Text>().text = "고수:" + span + "점";
        else if (span <50)
        {
            this.Score.GetComponent<Text>().text = "고인물:" + span + "점";
        }
        else
        {
            this.Score.GetComponent<Text>().text = "이제 좀 뒤지라고 ! :" + span + "점";
        }

    }


}
