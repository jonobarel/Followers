using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Direction : FollowerComponent
{
    public float ROTATIONSPEED = 0.03f;

    // Start is called before the first frame update0
    protected override void Start()
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
