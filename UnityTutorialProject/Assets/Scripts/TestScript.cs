using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("What Do You Want!");
        Debug.Log("You're Still Here!");
        Debug.Log("Go Away!");

     
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Words");
        
        transform.Translate(0.02f, 0, 0);
    }
}
