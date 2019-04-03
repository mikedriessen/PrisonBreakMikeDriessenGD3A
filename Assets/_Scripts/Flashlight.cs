using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
//using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    private bool ON;
    public Light flashlight;
    public Text flashlightText;

    // Start is called before the first frame update
    void Start()
    {
       SwitchOn(false);
        GameObject flashlight = new GameObject("Flashlight");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) )
        {
            SwitchOn(!ON);
            
        }

      

    }

    void SwitchOn(bool val)
    {
        ON = val;
        flashlight.enabled = val;
        flashlightText.enabled = !val;

    }
}
