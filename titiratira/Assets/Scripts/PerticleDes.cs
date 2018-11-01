using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerticleDes : MonoBehaviour {
    private float nowtime;

	// Use this for initialization
	void Start () {
        nowtime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        nowtime += Time.deltaTime;
        if(nowtime > 3)
        {
            Destroy(gameObject);
        }
	}
}
