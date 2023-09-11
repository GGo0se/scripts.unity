using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("escape")) // если нажата клавиша Esc (Escape)
        {
            SceneManager.LoadScene(0);
        }

    }
}
