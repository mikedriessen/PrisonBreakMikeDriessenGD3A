using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPartItem : Item
{
    public int partNo;

    public RaftPartItem(string name, float weight, int partNo) : base(name, weight)
    {
        this.partNo = partNo;
    }
}
