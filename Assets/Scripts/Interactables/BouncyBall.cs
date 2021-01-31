using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BouncyBall : MonoBehaviour
{
    public float pitchRange = 0.25f;
    private AudioSource bounceAudio;

    private void Start()
    {
        bounceAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        bounceAudio.pitch = Random.Range(1 - pitchRange, 1 + pitchRange);
        bounceAudio.Play();
    }
}
