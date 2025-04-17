using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ShopItemData")]
public class ShopItem : ScriptableObject
{
    public string itemCode;
    public Sprite itemIcon;
    public string itemName;
    public string itemType;
    public int itemValue;
}