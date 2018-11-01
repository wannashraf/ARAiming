using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour {
    public bool IsAlive = false;
    private GameObject master;
    public GameObject Effect;
    private GameSys GS;
    private Audio A;
    
    // Use this for initialization
    void Start()
    {
        master = GameObject.FindGameObjectWithTag("Master");
        GS = master.GetComponent<GameSys>();
    }
	
	// Update is called once per frame
	void Update () {
        if (IsAlive)
        {
            GS.ballcount--;
            var E = Instantiate(Effect);
            E.transform.position = gameObject.transform.position;
            E.GetComponent<Audio>().canexplode = true;
            Destroy(gameObject);
        }
	}
}
