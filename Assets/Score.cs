using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{
    private int score = 0; //外部から見えるように　整数オブジェクト宣言　名前スコア　
    private GameObject ScoreText;
    void Start()
  
        {
        this.ScoreText = GameObject.Find("Score");
        score = 0;
        SetScore();   
    }
   
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            score += 30;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 40;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 50;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 80;
        }
        else
        {
            score += 0;
        }

        SetScore();
    }

    void SetScore()
    {
        this.ScoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}
