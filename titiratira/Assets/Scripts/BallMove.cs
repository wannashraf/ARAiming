using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

    public bool canmoveing;
    public float movespeed;
    private float time;
    Rigidbody rb;
    private GameSys sys;
    public GameObject ballmaster;

    // Use this for initialization
    void Start () {
        canmoveing = true;
        rb = gameObject.GetComponent<Rigidbody>();
        time = 5;
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime; ballmaster = GameObject.FindGameObjectWithTag("Master");
        sys = ballmaster.GetComponent<GameSys>();
        if (sys.ballcount == 16)
        {
            movespeed = 0;
        }
        else if (sys.ballcount == 12)
        {
            movespeed = 1.5f;
        }
        else if (sys.ballcount == 8)
        {
            movespeed = 2.5f;
        }
        if (time > 5)
        {
            rb.velocity = new Vector3(Random.Range(-movespeed, movespeed), Random.Range(-movespeed, movespeed), Random.Range(-movespeed, movespeed));
            time = 0;
        }
	}
}
