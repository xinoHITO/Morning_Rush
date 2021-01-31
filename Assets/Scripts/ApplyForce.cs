using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public float Force = 600;

    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        _rigidbody.AddForce(transform.up * Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
