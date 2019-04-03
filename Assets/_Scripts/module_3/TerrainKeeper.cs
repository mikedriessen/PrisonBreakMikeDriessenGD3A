using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainKeeper : MonoBehaviour {

public static TerrainKeeper brain;


void Awake()
{
    if(TerrainKeeper.brain == null)
    {
        TerrainKeeper.brain = this;
        DontDestroyOnLoad(gameObject);
    }
    /*
    else
    {
        Destroy(gameObject);
    }
    */
}

}

