using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerComponent : MonoBehaviour
{
    // Start is called before the first frame update

    
    private Follower owner;

    public GameObject Target {
        get {return owner.target;}
    }

    public Vector3 getAdjustedTargetPosition() {
        Vector3 v = Target.transform.position;
        v.y = transform.position.y;
        return v;
    } 

    protected virtual void Start()
    {
        owner = gameObject.GetComponent<Follower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
