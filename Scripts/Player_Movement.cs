using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = 2.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-v * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(v * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, v * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -v * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Application.Quit();
        }
    }

    private void OnApplicationQuit()
    {
        Debug.Log("Game has Ended!");
    }
}
