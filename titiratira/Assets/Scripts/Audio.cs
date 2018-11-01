using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip boom;
    private AudioSource audioSource;
    public bool canexplode;

    // Use this for initialization
    void Start ()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canexplode)
        {
            audioSource.PlayOneShot(boom);
        }
        canexplode = false;
    }
}
