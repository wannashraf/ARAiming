using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInit : MonoBehaviour
{

    public GameObject BallPrefab;
    public GameObject Balls;
    public bool IsRestart;
    public int Ballcount=0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRestart)
        {
            for (int i = 0; i < Ballcount / 4; i++)
            {
                var g = Instantiate(BallPrefab, Balls.transform);
                g.transform.position = new Vector3(Random.Range(3, 6), Random.Range(3, 6), Random.Range(-6, 6));
            }
            for (int i = 0; i < Ballcount / 4; i++)
            {
                var g = Instantiate(BallPrefab, Balls.transform);
                g.transform.position = new Vector3(Random.Range(-6, -3), Random.Range(-6, -3), Random.Range(-6, 6));
            }
            for (int i = 0; i < Ballcount / 4; i++)
            {
                var g = Instantiate(BallPrefab, Balls.transform);
                g.transform.position = new Vector3(Random.Range(-6, -3), Random.Range(3, 6), Random.Range(-6, 6));
            }
            for (int i = 0; i < Ballcount / 4; i++)
            {
                var g = Instantiate(BallPrefab, Balls.transform);
                g.transform.position = new Vector3(Random.Range(3, 6), Random.Range(-6, -3), Random.Range(-6, 6));
            }
            IsRestart = false;
        }
    }
}