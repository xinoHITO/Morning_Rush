using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent OnClickedInteractable;

    protected virtual void OnMouseDown()
    {
        OnClickedInteractable?.Invoke();
    }

}
