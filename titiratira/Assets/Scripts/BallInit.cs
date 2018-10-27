using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInit : MonoBehaviour
{

    public GameObject BallPrefab;
    public GameObject Balls;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            var g = Instantiate(BallPrefab, Balls.transform);
            g.transform.position = new Vector3(Random.Range(-10,10), Random.Range(-10, 10), Random.Range(-10, 10));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}