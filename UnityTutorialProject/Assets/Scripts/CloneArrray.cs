using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class CloneArrray : MonoBehaviour
{

    [SerializeField]
    GameObject[] toClone;
    Vector3 randomPos = Vector3.zero;
    GameObject chosenToClone = null;
    GameObject clonedObject = null;

    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0; i < toClone.Length; i++)
        {
            chosenToClone = toClone[i];
            clonedObject = Instantiate(chosenToClone);
            randomPos.x = (i * 6 )-7;
            randomPos.y = (1);
            clonedObject.transform.position = randomPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
