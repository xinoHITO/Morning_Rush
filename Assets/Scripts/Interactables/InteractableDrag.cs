using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableDrag : Interactable
{
    public UnityEvent OnClickRelease;

    public bool DestroyWhenLettingGo = false;
    public float DistanceToDestroy = 10;
    private bool IsBeingDragged = false;

    private Vector3 StartingPos;

    void Start()
    {
        StartingPos = transform.position;
    }

    protected override void Update()
    {
        base.Update();

        if (IsBeingDragged)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (IsBeingDragged)
            {
                Release();
            }
        }

    }

    protected override void ClickInteractable()
    {
        base.ClickInteractable();
        IsBeingDragged = true;
    }

    //protected override void OnMouseDown()
    //{
    //    IsBeingDragged = true;
    //}

    //protected void OnMouseUp()
    //{
    //    Release();
    //}

    private void Release()
    {
        IsBeingDragged = false;

        OnClickRelease?.Invoke();

        if (!DestroyWhenLettingGo) return;

        float sqrDistance = Vector3.SqrMagnitude(StartingPos - transform.position);
        Debug.Log(sqrDistance);
        if (sqrDistance >= DistanceToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
