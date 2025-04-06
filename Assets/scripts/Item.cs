using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemData data;

    private void Start()
    {
        Debug.Log(data.itemName);
        Debug.Log(data.itemCode);
        Debug.Log(data.itemDescription);
    }
}