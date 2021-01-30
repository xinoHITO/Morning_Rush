using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public Transform LeftLimit;
    public Transform RightLimit;

    public float PanSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += h * PanSpeed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, LeftLimit.position.x, RightLimit.position.x);

        transform.position = pos;
    }
}
