using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item_Data", menuName = "ScriptableObjects/Item Data", order = 1)]
public class ItemScriptable : ScriptableObject
{
    public string ItemName = "New Item";
    public Sprite Image;
}
