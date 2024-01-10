using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClone : MonoBehaviour
{
    [SerializeField]
    GameObject[] toClone;
    GameObject chosenToClone = null;
    GameObject clonedObject = null;

    [SerializeField]
    float minpos = -10;
    [SerializeField]
    float maxPos = 10;
    Vector3 randomPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        int chosenIndex = Random.Range(0, toClone.Length);
        chosenToClone = toClone [chosenIndex];
        clonedObject = Instantiate(chosenToClone);
        randomPos.x = Random.Range(minpos, maxPos);
        randomPos.y = Random.Range(minpos, maxPos);
        clonedObject.transform.position = randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
