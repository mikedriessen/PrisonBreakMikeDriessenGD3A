using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionFollowPlayer : MonoBehaviour
{
    public Transform target;

    float speed = 10f;

    private void Start()
    {
        //go = this.gameObject.transform;
    }

    void Update()
    {
        
        Vector3 targetDir = target.position - transform.position;

        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
       

        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
