using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public Transform LeftLimit;
    public Transform RightLimit;

    public float PanSpeed = 5;

    private Vector3 StartinPos;

    void Awake()
    {
        StartinPos = transform.position;
    }

    private Vector3 PreviousMousePos;

    // Update is called once per frame
    void Update()
    {



        float h = Input.GetAxis("Horizontal");

        if (h == 0)
        {
            if (Input.GetMouseButton(1))
            {
                Vector3 mouseDelta = Input.mousePosition - PreviousMousePos;
                h = mouseDelta.x;
            }
        }



        Vector3 pos = transform.position;
        pos.x += h * PanSpeed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, LeftLimit.position.x, RightLimit.position.x);

        transform.position = pos;

        PreviousMousePos = Input.mousePosition;
    }

    public void ResetCameraPan()
    {
        transform.position = StartinPos;
    }
}
