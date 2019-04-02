using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private CharacterController cc;
    private CharacterMotor cm;
    private GameObject player;
    private Transform defaultPlayerTransform;

    private bool isDriving = false;

    public Rigidbody rb;

    private float startY;
    
   
   
    void Start()
    {
        cc = GameObject.FindObjectOfType<CharacterController>();
        cm = GameObject.FindObjectOfType<CharacterMotor>();
        player = cm.gameObject;
        defaultPlayerTransform = player.transform;

       // rb = GetComponent<Rigidbody>();
        
        startY = gameObject.transform.position.y;
    }

    bool IsPlayerCloseToBoat()
    {
        Debug.Log(isDriving);
        return Vector3.Distance(gameObject.transform.position, player.transform.position) < 1;

    }

    void SetDriving(bool isDriving)
    {
        this.isDriving = isDriving;

        cm.enabled = !isDriving;
        cc.enabled = !isDriving;

        if (isDriving)
        {
            player.transform.parent = gameObject.transform;
            
        }
        else
        {
            player.transform.parent = defaultPlayerTransform;
        }

      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsPlayerCloseToBoat())
        
            SetDriving(!isDriving);
        

        if (isDriving)
        {
            float forwardThrust = 0;
            if (Input.GetKeyDown(KeyCode.W))
            
                forwardThrust = 3;
            
            if (Input.GetKeyDown(KeyCode.S))
            
                forwardThrust = -1;



            rb.AddForce(gameObject.transform.forward * forwardThrust);
            

            float turnThrust = 0;
            if (Input.GetKeyDown(KeyCode.A))
            
               turnThrust = -1;
            
            if (Input.GetKeyDown(KeyCode.D))
            
               turnThrust = 1;
            
            
            rb.AddRelativeTorque(Vector3.up * turnThrust );
        }

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 5);
        Vector3 newPosition = gameObject.transform.position;
        newPosition.y = startY + Mathf.Sin(Time.timeSinceLevelLoad*4)/8;
        gameObject.transform.position = newPosition;
    }
}
