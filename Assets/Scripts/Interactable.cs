using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool DestroyWhenInteracted = true;
    public UnityEvent OnClickedInteractable;

    private void OnMouseDown()
    {
        OnClickedInteractable?.Invoke();
        InteractionsManager.Instance.ClickInteractable(this);

        if (DestroyWhenInteracted)
        {
            Destroy(gameObject);
        }
    }
}
