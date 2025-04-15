using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodeMining : MonoBehaviour
{
    public int oreProbability;
    public int miningTicket;
    public PlayerData inventoryManager;
    public TMPro.TextMeshProUGUI ticketAmount;
    public List<ItemData> ores = new List<ItemData>();
    
    
    public void OnclickMining()
    {
        
        if (miningTicket >= 1)
        {
            oreProbability = Random.Range(0, 100);
            if (oreProbability < 30)
            {
                inventoryManager.inventory.Add(ores[0]);
                Debug.Log("구리 얻었음 ㅇㅇ");
            }

            else if (oreProbability < 60)
            {
                inventoryManager.inventory.Add(ores[1]);
                Debug.Log("철 얻었음 ㅇㅇ");
            }

            else if (oreProbability < 75)
                Debug.Log("아연 얻었음 ㅇㅇ");

            else if (oreProbability < 90)
                Debug.Log("주석 얻었음 ㅇㅇ");

            else if (oreProbability < 95)
            {
                inventoryManager.inventory.Add(ores[2]);
                Debug.Log("은 얻었음 ㅇㅇ");
            }

            else if (oreProbability < 100)
            {
                inventoryManager.inventory.Add(ores[3]);
                Debug.Log("금 얻었음 ㅇㅇ");
            }
        }
        
    }
}
