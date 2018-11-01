using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSys : MonoBehaviour {

    public GameObject BallBox1;
    public GameObject BallBox2;
    public GameObject BallBox3;
    public GameObject Texta;
    public GameObject Textb;
    private GameObject Timer;
    private GameObject Last;

    public bool IsTracking;
    public bool timerstart;

    public int ballcount;
    public float nowtime;
    public bool IsGameOver;
    private bool Spawn;

    private DestroyBall DB;
    private BallInit BI1;
    private BallInit BI2;
    private BallInit BI3;

    public AudioClip shot;
    public AudioClip end;
    private AudioSource audioSource;


	// Use this for initialization
	void Start () {
        IsTracking = false;
        nowtime = 0;
        IsGameOver = false;
        BI1 = BallBox1.GetComponent<BallInit>();
        BI2 = BallBox2.GetComponent<BallInit>();
        BI3 = BallBox3.GetComponent<BallInit>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (IsTracking && Spawn == false)
        {
            if(ballcount == 20)
            {
                BallBox3.SetActive(true);
                BI3.Ballcount = ballcount;
                BI3.IsRestart = true;
            }
            else if (ballcount == 16)
            {
                BallBox2.SetActive(true);
                BI2.Ballcount = ballcount;
                BI2.IsRestart = true;
            }
            else if (ballcount == 8)
            {
                BallBox1.SetActive(true);
                BI1.Ballcount = ballcount;
                BI1.IsRestart = true;
            }
            Textb.SetActive(false);
            Texta.SetActive(true);
            Spawn = true;
            timerstart = true;
            IsGameOver = false;
        }

        if(!IsTracking && timerstart)
        {
            SceneManager.LoadScene("Main");
        }

        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                if (IsGameOver)
                {
                    SceneManager.LoadScene("Main");
                }
                else
                {
                    audioSource.PlayOneShot(shot);
                }


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

        if (timerstart)
        {
            if (ballcount > 0)
            {
                nowtime += Time.deltaTime;
                Timer = GameObject.FindGameObjectWithTag("Timer");
                Last = GameObject.FindGameObjectWithTag("Last");
                Timer.GetComponent<Text>().text = nowtime.ToString("F0")+" 秒";
                Last.GetComponent<Text>().text = ballcount.ToString();

            }
            else if (IsGameOver == false)
            {
                IsGameOver = true;
                Debug.Log("できてますよ");
                Textb.GetComponent<Text>().text = "終了！　タイム：" + nowtime.ToString("F0") + "秒！";
                audioSource.PlayOneShot(end);
                Texta.SetActive(false);
                Textb.SetActive(true);
                BallBox1.SetActive(false);
                BallBox2.SetActive(false);
                BallBox3.SetActive(false);
                timerstart = false;
            }
        }
	}
}
