using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public FixedJoystick joystick;

    public int score = 0;

    public float movespeed;

    private float hInput, vInput;

    public GameObject wintext;

    public int winscore = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        hInput = joystick.Horizontal * movespeed;
        vInput = joystick.Vertical * movespeed;
        
        transform.Translate(hInput, vInput, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Carrot")
        {
            score++;
            Destroy(collision.gameObject);

            if (score >= winscore)
            {
                wintext.SetActive(true);
            }
            
            
        }
        
        
        
    }
}
