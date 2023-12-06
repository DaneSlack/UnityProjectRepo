using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AcessMovement : MonoBehaviour
{

    [SerializeField]
    float speedMulti = 1f;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.Log("Null");
        }
        else
        {
            Debug.Log("Emoji");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetButtonDown("D"))
        {
            Debug.Log("something");
        }
        
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Spam");
        }

        if (Input.GetButtonUp("D"))
        {
            Debug.Log("something else");
        }
        
        if (Input.GetButton("Horizontal"))
        {
            transform.Translate(speedMulti * 0.01f, 0, 0);
        }
        */
       
       /* if (Input.GetAxis("Horizontal") >0)
        {
            transform.Translate(speedMulti * 0.01f, 0, 0);
        }
       */
        /* if(Input.GetAxis("Horizontal")  <0)
        {
            transform.Translate(Input.GetAxis("Horizontal") * -0.01f, 0, 0);
        }
        */
        transform.Translate(Time.deltaTime * speedMulti * Input.GetAxis("Horizontal") * 1f, 0, 0);

        transform.Translate(0, Time.deltaTime * speedMulti * Input.GetAxis("Vertical") * 1f, 0);


    }
}
