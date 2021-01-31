using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOffset : MonoBehaviour
{
    public float timeOffset = 8;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = timeOffset;
    }

}
