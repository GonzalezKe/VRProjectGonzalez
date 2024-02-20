using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    public AudioClip ballimpact;
    AudioSource audioSource;
    private Rigidbody rb;
    float ballmagnitude;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        ballmagnitude = rb.velocity.magnitude / 2;
        Debug.Log(ballmagnitude);
        if (ballmagnitude > 1) 
        {
            ballmagnitude = 1;
        }
        audioSource.PlayOneShot(ballimpact, ballmagnitude);
    }
}
