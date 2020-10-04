using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatCollsion : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject StartScreen;
    public Text Score;
    int iScore = 0;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            Score.text = "Score : " + ++iScore;
        }
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
        StartScreen.SetActive(true);
    }
}
