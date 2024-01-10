using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopArray : MonoBehaviour
{
    [SerializeField]
    string[] StringAr = null;
    [SerializeField]
    int[] IntAr = null;
    int IntTotal = 0;

    // Start is called before the first frame update
    void Start()
    {
        /* for (int i = 0; i < StringAr.Length; i++)
         {
             Debug.Log(StringAr[i]);
         } */

        /*
        foreach (string element in StringAr) 
        {
            Debug.Log(element);      
        }
        */
        for (int i = 0; i < IntAr.Length; i++)
        {
            IntTotal += IntAr[i];
        }
        Debug.Log(IntTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
