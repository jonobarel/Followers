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
        counter%=points.Length;
        return points[counter];

    }

}
