using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Rigidbody2D Bat;
    public int JumpForce = 25;
    public GameObject GameOver;
    public GameObject StartScreen;
    public GameObject Score;
    public float Timer = 2f;
    public GameObject OriginalWall;
  


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        GameOver.SetActive(false);
        StartScreen.SetActive(true);
        Score.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (GameOver.activeInHierarchy == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Time.timeScale = 1;
                StartScreen.SetActive(false);
                Score.SetActive(true);
                // Bat.AddForce(Vector3.up * Input.GetAxis("Jump") * JumpForce);
                Bat.velocity = transform.up * JumpForce;
                Bat.GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            Bat.GetComponent<AudioSource>().Stop();               

            if (Input.GetButtonDown("Jump"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        Timer -= Time.deltaTime;

        if (Timer <= 0f)
        {
            Instantiate(OriginalWall, new Vector2(47f, Random.Range(15f, 48f)), Quaternion.identity);
            Timer = 2f;
        }      

    }
}
