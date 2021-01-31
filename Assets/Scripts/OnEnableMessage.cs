using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableMessage : MonoBehaviour
{
    public UnityEvent OnEnableEvent;
    
    void OnEnable()
    {
        OnEnableEvent?.Invoke();
    }

}
