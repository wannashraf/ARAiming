using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler {
    public GameObject ballmaster;
    private GameSys sys;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        sys = ballmaster.GetComponent<GameSys>();
        sys.IsTracking = true;
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        sys = ballmaster.GetComponent<GameSys>();
        sys.IsTracking = false;
    }
}
