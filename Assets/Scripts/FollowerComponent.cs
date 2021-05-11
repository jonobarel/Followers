using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/***********************************

Base class for the movement components which establishes access to the owner GameObject's target parameter, and provides useful methods.


************************************/

public class FollowerComponent : MonoBehaviour
{
    // Start is called before the first frame update

    
    private Follower owner;

    public GameObject Target {
        get {return owner.target;}
        set {owner.target = value;}
    }

    public Vector3 getAdjustedTargetPosition() {
        Vector3 v = Target.transform.position;
        v.y = transform.position.y;
        return v;
    } 

    public float deltaVectorSqrMagnitude() {
        return ((getAdjustedTargetPosition() - transform.position).sqrMagnitude);
    }
    public virtual void Start()
    {
        owner = gameObject.GetComponent<Follower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
