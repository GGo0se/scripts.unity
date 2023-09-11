using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pllatforma : MonoBehaviour
{
    
    public float speed = 10f;

    public float x1 = 1;

    public float x2 = 2;

     float dirX;

     bool movingRight = true;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > x2)
        {
            movingRight = false;
        }
        if (transform.position.x < x1)
        {
            movingRight = true;
        }

        if (movingRight)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
