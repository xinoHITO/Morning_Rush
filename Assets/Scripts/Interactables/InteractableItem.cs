using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : Interactable
{
    public ItemScriptable ItemData;
    public bool DestroyWhenInteracted = true;
    public float DelayBeforeFailing = 0;

    private void OnEnable()
    {
        if (DelayBeforeFailing > 0)
        {
            StartCoroutine(FailCoroutine());
        }

        IEnumerator FailCoroutine()
        {
            yield return new WaitForSeconds(DelayBeforeFailing);
            Interact(false);
        }
    }

    protected override void ClickInteractable()
    {
        base.ClickInteractable();
        Interact(true);
    }

    private void Interact(bool success)
    {
        Inventory.Instance.ObtainItem(this, success);

        if (DestroyWhenInteracted)
        {
            Destroy(gameObject);
        }
    }
}
