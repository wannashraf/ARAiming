using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSys : MonoBehaviour {
    public GameObject BallBox;
    public bool IsTracking;
    public int ballcount;
    bool Spawn;
	// Use this for initialization
	void Start () {
        IsTracking = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (IsTracking && Spawn == false)
        {
            BallBox.SetActive(true);
            Spawn = true;
            ballcount = 30;
        }

	}
}
