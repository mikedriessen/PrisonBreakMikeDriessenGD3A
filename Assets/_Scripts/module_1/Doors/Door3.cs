using System.Collections;
using System.Collections.Generic;
//using BSGTools.EditorUtilities;
using UnityEngine;

public class Door3 : MonoBehaviour, IInteractable
{
    public int id;
    public bool open = false;
    private float initialRotation;
    public EYAGEKWEER weather;
    
    // Start is called before the first frame update
    void Start()
    
    {
        initialRotation = transform.rotation.eulerAngles.z; 
       
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open && transform.rotation.eulerAngles.z < initialRotation +1 && weather.canOpen)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-90, 0, initialRotation +1), 5);
        } else if (!open && transform.rotation.eulerAngles.z > initialRotation)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, initialRotation), 5);
        }
        
    }

    public void Open()
    {
        if (id == -1  || Inventory.instance.HasKey(id))
        {
            open = !open;
        }
    }

    public void Action()
    {
        Open();
    }
}