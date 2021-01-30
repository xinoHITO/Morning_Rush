using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [System.NonSerialized]
    public ItemScriptable ItemData;
    public Image InventoryItemImage;

    public void SetItem(ItemScriptable itemData)
    {
        ItemData = itemData;
        InventoryItemImage.sprite = itemData.Image;
    }

    public void MarkAsFound()
    {
        InventoryItemImage.color = Color.white;
    }
}
