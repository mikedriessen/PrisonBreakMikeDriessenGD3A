using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int raftPartsBuilt = 0;

    public GameObject player;
    public GameObject ui;

    public GameObject cinematic;
    public GameObject endUI;

    public void Ending()
    {
        ui.SetActive(false);
        player.SetActive(false);

        //cinematic.SetActive(true);
        //endUI.SetActive(true);
    }

}