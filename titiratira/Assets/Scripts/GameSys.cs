using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSys : MonoBehaviour {
    public GameObject BallBox;
    public GameObject Texta;
    public bool IsTracking;
    private bool timerstart;
    public int ballcount;
    public float nowtime;
    private DestroyBall DB;

    bool Spawn;
	// Use this for initialization
	void Start () {
        IsTracking = false;
        nowtime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (IsTracking && Spawn == false)
        {
            BallBox.SetActive(true);
            Spawn = true;
            ballcount = 30;
            timerstart = true;
        }

        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(new Vector2(Camera.main.pixelWidth/2,Camera.main.pixelHeight/2));
                RaycastHit hit = new RaycastHit();
                if (Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.tag == "unko")
                    {
                        DB = hit.collider.gameObject.GetComponent<DestroyBall>();
                        DB.IsAlive = true;
                    }
                }
            }
        }

        if(ballcount > 0 && timerstart)
        {
            nowtime += Time.deltaTime;
        }
        else
        {
            Texta.SetActive(true);
            Texta.GetComponent<Text>().text = nowtime.ToString();
        }

	}
}
