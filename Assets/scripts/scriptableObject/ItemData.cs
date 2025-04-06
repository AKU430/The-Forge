using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName = "Item")]
public class ItemData : ScriptableObject
{
    public string itemCode;
    public Sprite itemSprite;
    public string itemName;
    public int itemQuantity;
    [TextArea] public string itemDescription;
}
