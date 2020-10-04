using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float LifeTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 25 * Time.deltaTime);
        LifeTime -= Time.deltaTime; 
        if (LifeTime <= 0f)
        {
            LifeTime = 4f;
            Destroy(gameObject);
        }
    }

   
}
