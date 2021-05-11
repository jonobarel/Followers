using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*********************
Steering class
*********************/

public class Direction : FollowerComponent
{
    public float ROTATIONSPEED = 0.3f;

    // Start is called before the first frame update0
    public override void Start()
    {
        base.Start();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vDelta = getAdjustedTargetPosition() - transform.position;
        Debug.DrawRay(transform.position, vDelta, Color.red);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vDelta,transform.up), ROTATIONSPEED);
    }
}
