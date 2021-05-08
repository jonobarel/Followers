using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
[RequireComponent(typeof(Direction))]
[RequireComponent(typeof(ActionSelect))]
[RequireComponent(typeof(Move))]

public class FollowBase : MonoBehaviour
{
    private GameObject target;

    public GameObject Target {
        get {return target;}
        set {target = value;}
    }

    public Vector3 getAdjustedTargetPosition() {
        Vector3 v = Target.transform.position;
        v.y = transform.position.y;
        return v;
    } 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
