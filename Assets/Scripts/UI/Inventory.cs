using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public float DelayBeforeEvent = 1;
    public UnityEvent OnFilledInventory;
    public UnityEvent OnFilledInventoryDelayed;


    public ItemScriptable[] Items;
    public InventoryItem InventoryItemPrefab;
    public RectTransform Container;

    public InteractionResult InteractionResultPrefab;

    private List<InventoryItem> InventoryItems;

    private int GainedItems = 0;

    private static Inventory instance;
    public static Inventory Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("Inventory Manager");
                instance = go.AddComponent<Inventory>();
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
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (RectTransform item in Container)
        {
            Destroy(item.gameObject);
        }

        InventoryItems = new List<InventoryItem>();

        foreach (ItemScriptable item in Items)
        {
            var newItem = Instantiate(InventoryItemPrefab, Container);
            newItem.SetItem(item);

            InventoryItems.Add(newItem);
        }
    }

    public void ObtainItem(InteractableItem interactable, bool success)
    {
        var result = Instantiate(InteractionResultPrefab, interactable.transform.position, Quaternion.identity);
        result.SetResult(success);

        if (success)
        {
            foreach (var inventoryItem in InventoryItems)
            {
                if (interactable.ItemData == inventoryItem.ItemData)
                {
                    inventoryItem.MarkAsFound();
                    GainedItems++;
                    Debug.Log("Obtained item:" + interactable.ItemData.name);
                    break;
                }
            }

            if (GainedItems >= InventoryItems.Count)
            {
                OnFilledInventory?.Invoke();
                StartCoroutine(ObtainItemCoroutine());
            }
        }
            
        IEnumerator ObtainItemCoroutine()
        {
            yield return new WaitForSeconds(DelayBeforeEvent);
            OnFilledInventoryDelayed?.Invoke();
        }
    }
}
