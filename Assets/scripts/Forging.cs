using System;
using UnityEngine;

public class Forging : MonoBehaviour
{
    [Header("Config")]
    public TMPro.TextMeshProUGUI weaponName;
    public TMPro.TextMeshProUGUI weaponValue;
    public ParticleSystem forgingParticles;

    public void Update()
    {
        
    }

    public void Start()
    {
        WeapomInfo("단조된 금속 덩어리", 0);    
    }

    public void WeapomInfo(string name,int value)
    {
        weaponName.text = $"{name}";
        weaponValue.text = $"{value}";
    }

    public void OnclickForging()
    {
        forgingParticles.Play();
    }
}
