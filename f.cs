using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f : MonoBehaviour
{
    public float speed = 10f;

    float dirX;

    bool movingRight = true;
   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 48f)
        {
            movingRight = false;
        }
        if (transform.position.x < 46.42f)
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
