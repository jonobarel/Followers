using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

/***************************
Not used. Was meant to spawn sheep in a herd to follow the character
****************************/

public class HerdManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int flockSize;
    public Follower flockPrefab;

    private ArrayList flock;
    private Follower leader;
    public ThirdPersonCharacter characterController;
    public Follower Leader {
        get {return leader;}
    }

    void Awake()
    {
        flock = new ArrayList();
        Vector3 startPos = transform.position;
        for (int i = 0; i < flockSize; i++ ) {
            transform.position+=transform.forward*5f;
            transform.RotateAround(startPos, transform.up, 15);
            Follower sheep = Instantiate(flockPrefab, transform.position, Quaternion.identity);
            sheep.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
            flock.Add(sheep);
            sheep.herd = gameObject.GetComponent<HerdManager>();
            if (i==0) {
                leader = sheep;
            }

        }

        
    }

    private void Start() {
        foreach (Follower sheep in flock)
        {
            sheep.gameObject.SetActive(true);
        }
    }

    private void InitFlock(GameObject[] objects) {
        
      
    }
    
    void Update()
    {
        
    }
}
