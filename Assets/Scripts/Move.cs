using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : FollowerComponent
{

    bool moveState = false;
    public float speed = 5f;
    Animator anim;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    
    }

    public void Go() {
        anim.SetBool("walk", true);
        moveState = true;
    }

    public void Stop() {
        
        anim.SetBool("walk", false);
        moveState = false;

    }

    public void HardStop() {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveState) {
            //transform.position += jack.transform.forward*SPEED*Time.deltaTime;
            transform.position +=transform.forward*speed*Time.deltaTime; 
        }
    }
}
