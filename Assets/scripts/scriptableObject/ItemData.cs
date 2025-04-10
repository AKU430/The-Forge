using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemData")]
public class ItemData : ScriptableObject
{
    public string itemCode;
    public Sprite itemIcon;
    public string itemName;
    public string itemType;
}
