using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Movement : MonoBehaviour
{
    public float backgroundSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 backgroundOffSet = new Vector2(Time.time * backgroundSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = backgroundOffSet;
    }
}
