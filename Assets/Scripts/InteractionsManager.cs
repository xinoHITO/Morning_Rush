using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionsManager : MonoBehaviour
{
    public InteractionResult InteractionResultPrefab;

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

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }

    public void ClickInteractable(Interactable interactable, bool success)
    {
        var result = Instantiate(InteractionResultPrefab, interactable.transform.position, Quaternion.identity);
        result.SetResult(success);
        Debug.Log("CLICKED");
    }
}
