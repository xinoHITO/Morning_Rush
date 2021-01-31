using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDrag : Interactable
{
    public bool DestroyWhenLettingGo = false;
    public float DistanceToDestroy = 10;
    private bool IsBeingDragged = false;

    private Vector3 StartingPos;

    void Start()
    {
        StartingPos = transform.position;
    }

    private void Update()
    {
        if (IsBeingDragged)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }
    }

    protected override void OnMouseDown()
    {
        IsBeingDragged = true;
    }

    protected void OnMouseUp() {
        IsBeingDragged = false;

        if (!DestroyWhenLettingGo) return;
        
        float sqrDistance = Vector3.SqrMagnitude(StartingPos - transform.position);
        Debug.Log(sqrDistance);
        if (sqrDistance >= DistanceToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
