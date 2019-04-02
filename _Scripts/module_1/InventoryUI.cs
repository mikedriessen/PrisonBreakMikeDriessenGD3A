﻿using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI instance;
    
    public GameObject itemPrefab;
    private Dictionary<string, Pickup> items;
    public Transform parent;

    public void Awake()
    {
        Debug.Log("Awake");
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log(instance);
        }
        else
        {    
            Destroy(this);
        }
        
        items = new Dictionary<string, Pickup>();
    }

    void Start()
    {
        //gameObject.SetActive(false);
    }

    public void RegisterPickUpItem(Pickup i)
    {
        if (!items.ContainsKey(i.objectName))
        {
            items.Add(i.objectName, i);
        }
    }

    public void Add(Item i)
    {
        Debug.Log("Adding item to canvas.");
        if (items.ContainsKey(i.name) && !items[i.name].isInInventory())
        {
            Debug.Log("passed tests");
            GameObject go = Instantiate(itemPrefab, transform);
            go.GetComponent<Image>().sprite = items[i.name].image;
            go.transform.GetChild(0).GetComponent<Text>().text = i.name;
            items[i.name].setInventoryObj(go);
        }
    }

    public void Remove(Item i)
    {
        if (items.ContainsKey(i.name))
        {
            items[i.name].Respawn();
        }
    }
}
