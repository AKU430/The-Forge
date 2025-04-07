using UnityEngine;

[CreateAssetMenu(menuName = "ItemData")]
public class ItemData : ScriptableObject
{
    public string itemCode;
    public Sprite itemSprite;
    public string itemName;
    [TextArea] public string itemDescription;
}
