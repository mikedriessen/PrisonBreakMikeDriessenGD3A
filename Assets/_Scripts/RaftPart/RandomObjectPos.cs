using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectPos : MonoBehaviour
{

    public float maxWidth;
    public float minWidth;

    public float maxHeight;
    public float minHeight;

    public float maxDepth;
    public float minDepth;


    public GameObject[] obj;

    

    void Start()
    { 
        for(int i = 0; i < obj.Length; i++)
        {
            obj[i] = GameObject.FindGameObjectWithTag("obj" +i).gameObject;
            Spawn(i);
            
        }
    }

    void Spawn(int i) {

        float randWitdh = Random.Range(minWidth, maxWidth);
        float randHeight = Random.Range(minHeight, maxHeight);
        float randDepth = Random.Range(minDepth, maxDepth);
        Debug.Log("Spawn: " + i + " Witdh: " + randWitdh + "Depth" + randDepth + "Height:"+ randHeight);

        Vector3 random =  new Vector3(randWitdh, randHeight, randDepth ); 

        Instantiate (obj[i], random, Quaternion.identity);
    }
}

