using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodeMining : MonoBehaviour
{
    public int oreQuantity;
    public int miningAmount;
    public int oreProbability;
    
    public void OnclickMining()
    {
        oreProbability = Random.Range(0, 100);
        if (oreProbability < 30)
            Debug.Log("구리 얻었음 ㅇㅇ");
        else if (oreProbability < 60)
            Debug.Log("철 얻었음 ㅇㅇ");
        else if (oreProbability < 75)
            Debug.Log("아연 얻었음 ㅇㅇ");
        else if (oreProbability < 90)
            Debug.Log("주석 얻었음 ㅇㅇ");
        else if (oreProbability < 95)
            Debug.Log("금 얻었음 ㅇㅇ");
        else if (oreProbability < 100)
            Debug.Log("은 얻었음 ㅇㅇ");
    }
}
