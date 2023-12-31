using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PERSONAL1 : MonoBehaviour
{
    public float speed = 1f;
    public float jumpforce = 5f;


    Rigidbody2D rb;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal"); //-1 left 1 right
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05f) 
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        
        sr.flipX = movement > 0 ? true : false ;
        



    }
}
