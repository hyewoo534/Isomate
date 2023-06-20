using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    public float movespeed = 2.0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");   
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV).normalized * movespeed;
    }
}

