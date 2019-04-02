using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPart : Pickup
{
    public int partNo;

    protected override Item CreateItem()
    {
        return new RaftPartItem(objectName, weight, partNo);
    }
}