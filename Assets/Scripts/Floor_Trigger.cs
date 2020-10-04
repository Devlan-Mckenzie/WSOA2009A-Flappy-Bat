using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Trigger : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject StartScreen;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
        StartScreen.SetActive(true);
    }
}
