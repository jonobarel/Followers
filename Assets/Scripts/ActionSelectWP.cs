using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSelectWP : ActionSelect
{
    WaypointCollection wpl;
    public float wpProximityThreshold = 0.5f;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
        wpl = GetComponent<LookaheadWP>().wpList;
        maxDistance = wpProximityThreshold;

        Target = wpl.GetFirstWaypoint().gameObject;
        
    }

    // Update is called once per frame
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (deltaVectorSqrMagnitude() < minDistance * minDistance) {
            Target = wpl.GetNextWaypoint().gameObject;
        }

    }

    private float deltaVectorSqrMagnitude() {
        return ((getAdjustedTargetPosition() - transform.position).sqrMagnitude);
    }
}
