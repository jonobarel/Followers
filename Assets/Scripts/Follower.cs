using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Follower : MonoBehaviour
{
    public GameObject target;
    public bool isLeader;
    public HerdManager herd;
    private Follower leader;
    private ActionSelect actionComponent;
    private Move moveComponent;
    private Direction dirComponent;
    // Start is called before the first frame update
    
    void Start()
    {
        actionComponent = GetComponent<ActionSelect>();
        moveComponent = GetComponent<Move>();
        dirComponent = GetComponent<Direction>();
        
        //leader = herd.Leader;
        //Target = leader.gameObject;
        Debug.Log("I'm following: "+target.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
