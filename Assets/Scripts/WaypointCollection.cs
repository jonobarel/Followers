using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointCollection : MonoBehaviour
{
    // Start is called before the first frame update
    public Waypoint[] points;

    int counter = 0;

    public Waypoint GetFirstWaypoint() {
        return points[0];
    }

    public Waypoint GetNextWaypoint() {
        ++counter;
        return points[counter%points.Length];

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
