using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ActionSelect))]
[RequireComponent(typeof(Direction))]
[RequireComponent(typeof(Move))]
public class Follower : MonoBehaviour
{
    [SerializeField]
    private Lookahead lookaheadPrefab;
    public GameObject target;
    public HerdManager herd;
    private ActionSelect actionComponent;
    private Move moveComponent;
    private Direction dirComponent;
    // Start is called before the first frame update

    public float speed {
        get {return moveComponent.speed; }
    }

    public float minDistance {
        get {return actionComponent.minDistance;}
    }

    public float maxDistance {
        get {return actionComponent.maxDistance;}
    }

    
    public void SetMotionParams(float speed, float minDistance, float maxDistance) {
        Debug.Log(name+": Setting motion params");
        actionComponent.maxDistance = maxDistance;
        actionComponent.minDistance = minDistance;
        moveComponent.speed = speed;

    }

    public virtual void Start()
    {   Debug.Log(name+": start()");
        actionComponent = GetComponent<ActionSelect>();
        moveComponent = GetComponent<Move>();
        dirComponent = GetComponent<Direction>();
        
        //leader = herd.Leader;
        //Target = leader.gameObject;
        
        AdjustTargets();

    }

    public virtual void AdjustTargets() {
        //The Follower class will spawn a Lookahead, whereas the Lookahead will not.
        //Debug.Log("Spawning Lookahead");
        Lookahead la = Instantiate(lookaheadPrefab,transform.position,transform.rotation);
        la.gameObject.name = "Lookahead for" + name;
        la.gameObject.SetActive(true);
        la.target = target;
        la.follower = gameObject.GetComponent<Follower>();
        target = la.gameObject;
    }
    void FixedUpdate()
    {
        Debug.DrawLine(transform.position, target.transform.position,Color.red);
        
    }
}
