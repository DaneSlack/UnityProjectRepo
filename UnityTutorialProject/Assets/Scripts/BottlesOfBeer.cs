using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BottlesOfBeer : MonoBehaviour
{
    [SerializeField]
    int numBottles = 99;
    [SerializeField]
    int numToDrink = 99;
    int numDrunk = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 1)
        {
            while (numToDrink > numDrunk)
            {
                if ((numToDrink - numDrunk) > 2)
                {
                    Debug.Log(numBottles + " bottles of beer on the wall, " + numBottles + " bottles of beer.");
                    if (numBottles > 0)
                    {
                        numBottles = numBottles - 1;
                    }
                Debug.Log("Take one down and pass it around, " + numBottles + " bottles of beer on the wall.");
                    numDrunk = numDrunk + 1;
                }
                if ((numToDrink - numDrunk) == 2)
                {
                    Debug.Log(numBottles + " bottles of beer on the wall, " + numBottles + " bottles of beer.");
                    if (numBottles > 0)
                    {
                        numBottles = numBottles - 1;
                    }
                Debug.Log("Take one down and pass it around, " + numBottles + " bottle of beer on the wall.");
                    numDrunk = numDrunk + 1;
                }
                if ((numToDrink - numDrunk) == 1)
                {
                    Debug.Log(numBottles + " bottle of beer on the wall, " + numBottles + " bottle of beer.");
                    if (numBottles > 0)
                    {
                        numBottles = numBottles - 1;
                    }
                Debug.Log("Take one down and pass it around, no more bottles of beer on the wall.");
                    numDrunk = numDrunk + 1;
                }
                if (numDrunk == numToDrink)
                {
                    Debug.Log("No more bottles of beer on the wall, no more bottles of beer.");
                    if (numBottles > 0)
                    {
                        numBottles = numBottles - 1;
                    }
                    numToDrink = numToDrink - 1;
                    Debug.Log("Go to the store and buy some more, 99 bottles of beer on the wall.");
                    Debug.Log(numDrunk);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
