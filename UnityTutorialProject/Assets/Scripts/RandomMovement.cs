using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float randomX = 0;

    [SerializeField]
    float randomY = 0;

    [SerializeField]
    float wanderDuration = 0;

    [SerializeField]
    float randomSpeed = 0;

    [SerializeField]
    float wanderstartTime = 3;

    [SerializeField]
    float unityRunTime = 0;

    [SerializeField]
    float savedUnityRunTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        /*ranX = Random.Range(-1.0f, 1.0f);
        ranY = Random.Range(-1.0f, 1.0f);
        //direction.Normalize();
        Vector2 direction = new Vector2(ranX, ranY).normalized;
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (wanderDuration + savedUnityRunTime <= Time.time)
        {
            savedUnityRunTime = Time.time;
            wanderDuration = Random.Range(2.0f, 5.0f);
            randomSpeed = Random.Range(0.1f, 0.5f);
            randomX = Random.Range(-1.0f, 1.0f);
            randomY = Random.Range(-1.0f, 1.0f);;
        }
        unityRunTime = Time.time;
        Vector2 direction = new Vector2(randomX, randomY).normalized;
        transform.Translate(randomSpeed * direction * Time.deltaTime, 0);

    }
}
