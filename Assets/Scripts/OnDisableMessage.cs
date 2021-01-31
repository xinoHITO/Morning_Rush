using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDisableMessage : MonoBehaviour
{
    public UnityEvent OnDisableEvent;

    void OnDisable()
    {
        OnDisableEvent?.Invoke();
    }

}
