using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemSlot
{
    public ItemData item;
    public int itemQuantity;
}

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    public int gold;
    public int miningTicket;
    public List<ItemSlot> itemSlots = new List<ItemSlot>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
