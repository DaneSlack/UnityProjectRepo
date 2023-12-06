using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    float TimeVer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                TimeVer = Time.timeScale;
            }
            else
            {
                Time.timeScale = 1.0f;
                TimeVer = Time.timeScale;
            }
        }
    }
}
