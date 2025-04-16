using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "RefinedOre")]
public class RefinedOreData : ScriptableObject
{
    [Tooltip("아이템 코드")] public string itemCode;
    [Tooltip("아이템 아이콘")] public Sprite itemIcon;
    [Tooltip("아이템 이름")] public string itemName;
    [Tooltip("아이템 종류")] public string itemType;
    [Tooltip("광석 제련시 사용될 재료")]public ItemData itemIngredient;
}