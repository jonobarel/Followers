using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookahead : Follower
{
    // Start is called before the first frame update
    public Follower follower;
    
    override public void AdjustTargets() {

    }
    public override void Start()
    {
        base.Start();
        SetMotionParams(follower.speed, follower.minDistance, follower.maxDistance);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
