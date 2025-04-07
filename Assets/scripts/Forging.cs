using System;
using UnityEngine;
using UnityEngine.UI;

public class Forging : MonoBehaviour
{
    [Header("Config")]
    public TMPro.TextMeshProUGUI weaponName;
    public TMPro.TextMeshProUGUI weaponValue;
    public ParticleSystem forgingParticles;
    public Animator invController;
    public GameObject OpenButton;
    public GameObject CloseButton;
    
    public void Start() 
    {
        CloseButton.SetActive(false);
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

    public void OnclickInvntoryOpen()
    {
        OpenButton.SetActive(false);
        invController.SetTrigger("Open");
        CloseButton.SetActive(true);
    }
    
    public void OnclickInvntoryClose()
    {
        CloseButton.SetActive(false);
        invController.SetTrigger("Close");
        invController.SetTrigger("Return");
        OpenButton.SetActive(true);
    }
}
