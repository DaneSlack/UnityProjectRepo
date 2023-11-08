using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gacha : MonoBehaviour
{
    [SerializeField]
    int currency = 0;

    [SerializeField]
    int rewardChance = 0;

    [SerializeField]
    int rewardAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        currency = Random.Range(1, 10);
        currency = currency * 10;
        rewardAmount = Random.Range(1, 6);
        rewardChance = Random.Range(1, 5);

        if (1<10)
        { }





    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(currency);
            if (currency >= 10)
            {
                currency = currency - 10;
                
                if (rewardChance >= 4)
                {
                    rewardChance = 0;
                    currency = (rewardAmount * 10) + currency;
                }
                rewardChance = Random.Range(1, 5);
                rewardAmount = Random.Range(1, 6);
            }
        }
    }
}
