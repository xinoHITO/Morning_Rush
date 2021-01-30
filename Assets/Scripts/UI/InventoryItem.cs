using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Image ItemImage;
    private bool Found;
    
    public void GetItem() {
        Found = true;
        ItemImage.color = Color.white;
    }
}
