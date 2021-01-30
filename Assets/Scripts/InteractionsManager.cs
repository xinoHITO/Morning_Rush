using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionsManager : MonoBehaviour
{
    public UnityEvent OnClickedInteractable;

    private static InteractionsManager instance;
    public static InteractionsManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("Interactions Manager");
                instance = go.AddComponent<InteractionsManager>();
            }
            return instance;
        }
    }

    public void ClickInteractable() {
        Debug.Log("CLICKED");
        OnClickedInteractable?.Invoke();
    }
}
