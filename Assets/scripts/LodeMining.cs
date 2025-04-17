using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class LodeMining : MonoBehaviour
{
    public int oreProbability;
    public TextMeshProUGUI ticketAmount;
    public List<ItemData> ores = new List<ItemData>();

    private void Start()
    {
        ticketAmount.text = $"채굴권 : {PlayerData.instance.miningTicket}";
    }
    
    public void OnclickMining()
    {

        if (PlayerData.instance.miningTicket >= 1)
        {
            oreProbability = Random.Range(0, 100);
            if (oreProbability < 30)
            {
                CheckSlots(ores[0]);
                PlayerData.instance.miningTicket--;
                Debug.Log("구리 얻었음 ㅇㅇ");
            }

            else if (oreProbability < 60)
            {
                CheckSlots(ores[1]);
                PlayerData.instance.miningTicket--;
                Debug.Log("철 얻었음 ㅇㅇ");
            }

            else if (oreProbability < 75)
                Debug.Log("아연 얻었음 ㅇㅇ");
    
            else if (oreProbability < 90)
                Debug.Log("주석 얻었음 ㅇㅇ");

            else if (oreProbability < 95)
            {
                CheckSlots(ores[2]);
                PlayerData.instance.miningTicket--;
                Debug.Log("은 얻었음 ㅇㅇ");
            }

            else if (oreProbability < 100)
            {
                CheckSlots(ores[3]);
                PlayerData.instance.miningTicket--;
                Debug.Log("금 얻었음 ㅇㅇ");
            }
        }
    }

    public void CheckSlots(ItemData item)
    {
        var found = false;
        var playerData = PlayerData.instance.itemSlots;
        for (var i = 0; i < playerData.Count; i++)
        {
            if (playerData[i].item == item)
            {
                ticketAmount.text = $"채굴권 : {PlayerData.instance.miningTicket}";
                playerData[i].itemQuantity++;
                found = true;
                break;
            }
        }
        if (!found)
        {
            ticketAmount.text = $"채굴권 : {PlayerData.instance.miningTicket}";
            ItemSlot slot = new ItemSlot();
            slot.item = item;
            slot.itemQuantity = 1;
            playerData.Add(slot);
        }
    }
}
