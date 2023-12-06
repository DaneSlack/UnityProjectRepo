using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov1 : MonoBehaviour
{
    [SerializeField]
    float speedMulti = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Make Britain Great Again!");
        }*/
        /*if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Said every bigot ever");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("SPAMSPAMSPAMSPAMSPAMSPAMSPAM");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Dont Make Britain Great Again!");
        }*/
        /*if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right");
            transform.Translate(speedMulti * 0.01f, 0, 0);
        }*/
        if (Input.GetButton("MoveRight"))
        {
            Debug.Log("right");
            transform.Translate(speedMulti * 0.01f, 0, 0);
        }
            /*if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("left");
                transform.Translate(speedMulti * -0.01f, 0, 0);
            }*/
            if (Input.GetButton("MoveLeft"))
        {
            Debug.Log("left");
            transform.Translate(speedMulti * -0.01f, 0, 0);
        } 
        /*if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up");
            transform.Translate(0, speedMulti * 0.01f, 0);
        }*/
        if (Input.GetButton("Up"))
        {
            Debug.Log("up");
            transform.Translate(0, speedMulti * 0.01f, 0);
        }

        /*if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("down");
            transform.Translate(0, speedMulti * -0.01f, 0);
        }*/
        if (Input.GetButton("MoveDown"))
        {
            Debug.Log("down");
            transform.Translate(0, speedMulti * -0.01f, 0);
        }
    }
}
