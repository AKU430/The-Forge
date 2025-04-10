using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Forging : MonoBehaviour
{
    [Header("파티클 및 오디오 설정")]
    [Tooltip("단조 효과로 사용할 파티클")]
    public ParticleSystem forgingParticles;

    [Tooltip("UI 전환 애니메이터")]
    public Animator menuController;

    [Tooltip("단조 효과음을 재생할 Audio Source")]
    public AudioSource forgingAudioSource;

    [Tooltip("단조 효과음 클립")]
    public AudioClip forgingSound;
    
    [Space(10)]
    [Header("무기 정보 UI")]
    [Tooltip("무기 이름을 표시하는 텍스트")]
    public TextMeshProUGUI weaponName;

    [Tooltip("무기 가치를 표시하는 텍스트")]
    public TextMeshProUGUI weaponValue;

    [Space(10)]
    [Header("UI 버튼")]
    [Tooltip("메뉴 열기 버튼")]
    public GameObject openButton;

    [Tooltip("메뉴 닫기 버튼")]
    public GameObject closeButton;

    [Space(10)]
    [Header("인벤토리")]
    [Tooltip("인벤토리 오브젝트")]
    public GameObject inventory;
    
    public void Start() 
    {
        
    }

    private void WeaponInfo(string name,int value)
    {
        weaponName.text = $"{name}";
        weaponValue.text = $"{value}";
    }

    public void OnclickForging(int mode)
    {
        if (mode == 0)
        {
            
        }
        else
        {
            
        }
        /*forgingAudioSource.PlayOneShot(forgingSound);
        forgingParticles.Play();*/
    }

    public void OnclickMenuOpen()
    {
        openButton.SetActive(false);
        menuController.SetTrigger("Open");
        closeButton.SetActive(true);
    }

    public void OnclickInventoryOpen()
    {
        inventory.SetActive(true);
    }
    
    public void OnclickMenuClose()
    {
        closeButton.SetActive(false);
        menuController.SetTrigger("Close");
        menuController.SetTrigger("Return");
        openButton.SetActive(true);
    }
}
