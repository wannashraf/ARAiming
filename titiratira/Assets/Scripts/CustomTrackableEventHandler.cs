using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler {
    public GameObject ballmaster;
    private GameSys sys;
    private BallInit BI;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        sys = ballmaster.GetComponent<GameSys>();
        sys.IsTracking = true;
        if (!sys.timerstart)
        {
            if (gameObject.name == "asagi")
            {
                Debug.Log("asagi");
                sys.ballcount = 8;
            }
            else if (gameObject.name == "kemo")
            {
                Debug.Log("kemo");
                sys.ballcount = 16;
            }
            else if (gameObject.name == "DT")
            {
                Debug.Log("DT");
                sys.ballcount = 20;
            }
        }
        
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        sys = ballmaster.GetComponent<GameSys>();
        sys.IsTracking = false;
    }
}
