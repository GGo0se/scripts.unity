using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed = 10f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey((KeyCode.X)))
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime); 
        if (Input.GetKey((KeyCode.Z)))
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime); 
    }
}
