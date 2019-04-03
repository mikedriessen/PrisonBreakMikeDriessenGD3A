using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour, IInteractable
{
    public int raftNo;
    public Material raftMaterial;

    public GameManager gm;

    public void Action()
    {
        Open();
    }

    public void Open()
    {
        if (Inventory.instance.HasRaftpart(raftNo) && GetComponent<Renderer>().material != raftMaterial)
        {
            GetComponent<Renderer>().material = raftMaterial;
            gm.raftPartsBuilt++;
            if (gm.raftPartsBuilt == 4)
            {
                gm.Ending();
            }
        }
    }

}