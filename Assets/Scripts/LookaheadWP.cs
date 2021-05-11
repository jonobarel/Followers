using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*********************

The LookaheadWP class extends the base Lookahead by adding a WaypointCollection.
The follwer object still spawns this one, and continues to follow it the whole time, but the lookahead essentially adjusts its target
when it reaches each waypoint

*********************/
public class LookaheadWP : Lookahead
{
    // Start is called before the first frame update
    public WaypointCollection wpList;

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
