using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ActionSelect : FollowerComponent
{

    Move moveComponent;
    public float maxDistance = 10f;
    public float minDistance = 0.5f;
    //private GameObject target;
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        moveComponent = GetComponent<Move>();
    }

    // Update is called once per frame
    virtual public void FixedUpdate()
    {
        if ((getAdjustedTargetPosition() - transform.position).sqrMagnitude > maxDistance*maxDistance) {
            moveComponent.Go();
        }
        else {
            moveComponent.Stop();
        }
    }

}
