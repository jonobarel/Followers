using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*******************

Extension of the ActionSelect class designed to work with WaypointCollection.
When reaching a waypoint, this class will auto-retrieve the next one.

*******************/
public class ActionSelectWP : ActionSelect
{
    WaypointCollection wpl;
    public float wpProximityThreshold = 0.5f;

    [SerializeField]
    private float distanceToTarget;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
        wpl = GetComponent<LookaheadWP>().wpList;
        maxDistance = wpProximityThreshold;

        Target = wpl.GetFirstWaypoint().gameObject;
        Debug.Log("First waypoint: " + Target.name);
        
    }

    // Update is called once per frame
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (deltaVectorSqrMagnitude() < minDistance * minDistance) {
            Target = wpl.GetNextWaypoint().gameObject;
            Debug.Log("Next waypoint: " + Target.name);
        }

        distanceToTarget = Mathf.Sqrt(deltaVectorSqrMagnitude());

    }

}
