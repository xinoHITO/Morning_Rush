using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool DestroyWhenInteracted = true;
    public float DelayBeforeFailing = 0;
    public UnityEvent OnClickedInteractable;

    private void OnEnable()
    {
        if (DelayBeforeFailing > 0)
        {
            StartCoroutine(FailCoroutine());
        }

        IEnumerator FailCoroutine() {
            yield return new WaitForSeconds(DelayBeforeFailing);
            Interact(false);
        }
    }

    private void OnMouseDown()
    {
        OnClickedInteractable?.Invoke();
        Interact(true);
    }

    private void Interact(bool success) {
        InteractionsManager.Instance.ClickInteractable(this, success);

        if (DestroyWhenInteracted)
        {
            Destroy(gameObject);
        }
    }
}
