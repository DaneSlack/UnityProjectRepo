using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [SerializeField]
    float targetingScale = 0;

    [SerializeField]
    SpriteRenderer playerSprite = null;

    [SerializeField]
    Color spriteColor = Color.cyan;
 
    Vector3 changingScale = new Vector3 (1.0f, 1.0f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("What Do You Want!");
        //Debug.Log("You're Still Here!");
        //Debug.Log("Go Away!");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.02f, 0, 0);
        Debug.Log("Words");

        //targetingScale = targetingScale + 0.01f;
        //Debug.Log(targetingScale);

        //changingScale.x = targetingScale;
        //changingScale.y = targetingScale;
        //changingScale.z = targetingScale;

        //transform.localScale = changingScale;

    }

    public static implicit operator TestScript(Color v)
    {
        throw new NotImplementedException();
    }
}
