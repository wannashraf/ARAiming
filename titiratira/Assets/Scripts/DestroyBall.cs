using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour {
    public bool IsAlive = false;
    public GameObject master;
    private GameSys GS;
	// Use this for initialization
	void Start () {
        master = GameObject.FindGameObjectWithTag("Master");
        GS = master.GetComponent<GameSys>();
	}
	
	// Update is called once per frame
	void Update () {
        if (IsAlive)
        {
            GS.ballcount--;
            Destroy(gameObject);
        }
	}
}
