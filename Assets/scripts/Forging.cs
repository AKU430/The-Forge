using System;
using UnityEngine;
using UnityEngine.UI;

public class Forging : MonoBehaviour
{
    [Header("Config")]
    public TMPro.TextMeshProUGUI weaponName;
    public TMPro.TextMeshProUGUI weaponValue;
    public ParticleSystem forgingParticles;
    public Animator menuController;
    public GameObject openButton;
    public GameObject closeButton;
    public AudioSource forgingAudioSource;
    public AudioClip forgingSound;
    public void Start() 
    {
        closeButton.SetActive(false);
        WeaponInfo("단조된 금속 덩어리", 0);    
    }

    private void WeaponInfo(string name,int value)
    {
        weaponName.text = $"{name}";
        weaponValue.text = $"{value}";
    }

    public void OnclickForging()
    {
        forgingAudioSource.PlayOneShot(forgingSound);
        forgingParticles.Play();
    }

    public void OnclickMenuOpen()
    {
        openButton.SetActive(false);
        menuController.SetTrigger("Open");
        closeButton.SetActive(true);
    }
    
    public void OnclickMenuClose()
    {
        closeButton.SetActive(false);
        menuController.SetTrigger("Close");
        menuController.SetTrigger("Return");
        openButton.SetActive(true);
    }
}
