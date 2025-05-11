using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Forging : MonoBehaviour//, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("파티클 및 오디오 설정")]
    [Tooltip("단조 효과로 사용할 파티클")] public ParticleSystem forgingParticles;
    [Tooltip("메뉴 애니메이터")] public Animator menuController;
    [Tooltip("상점 애니메이터")] public Animator shopController;
    [Tooltip("단조 효과음을 재생할 Audio Source")] public AudioSource forgingAudioSource;
    [Tooltip("단조 효과음 클립")] public AudioClip forgingSound;
    
    [Space(10)]
    [Header("무기 정보 UI")]
    [Tooltip("무기 이름을 표시하는 텍스트")] public TextMeshProUGUI weaponName;
    [Tooltip("무기 가치를 표시하는 텍스트")] public TextMeshProUGUI weaponValue;

    [Space(10)]
    [Header("UI 버튼")]
    [Tooltip("메뉴 열기 버튼")] public GameObject openButton;
    [Tooltip("메뉴 닫기 버튼")] public GameObject closeButton;

    [Space(10)]
    [Header("창")]
    [Tooltip("인벤토리 오브젝트")] public GameObject inventory;
    [Tooltip("세이브 오브젝트")] public GameObject dataSave;
    [SerializeField][Tooltip("전체 창")] private List<GameObject> allWindows = new List<GameObject>();

    [Space(height: 10)] 
    [Header("메인버튼 관련 인스펙터")] 
    [Tooltip("제련, 단조 창이 열림 감지 변수")] public bool isOtherWindow = false;
    [Tooltip("작업 총괄하는 버튼")] public GameObject mainButton;
    [Tooltip("제련, 단조 작업 선택 오브젝트")] public GameObject workChoose;
    [Tooltip("제련 작업 오브잭트")] public GameObject smelter;
    [Tooltip("단조 작업 오브잭트")] public GameObject anvil;
    [Tooltip("제련 작업 슬롯 리스트")] public List<ItemData> allItems = new List<ItemData>();
        
    [Space(10)]
    [Header("데이터 뭉탱이")]
    [Tooltip("구매가능 아이템 데이터")] public ShopItem shopItem;
    [Tooltip("무기 데이터")] public WeaponData weaponData;
    [Tooltip("광석 등 데이터")] public ItemData itemData;
    [Tooltip("제련 광석 데이터")] public RefinedOreData refinedOreData;

    //메인 버튼 작업 관리자
    public enum WorkMode
    {
        WorkChoose, 
        Forging, 
        Smelting
    }
    
    public void OnClickWorkChoose() => WorkManager(WorkMode.WorkChoose);
    
    public void WorkManager(WorkMode mode)
    {
        switch (mode)
        {
            case WorkMode.WorkChoose:
                if (isOtherWindow == false)
                {
                    Debug.Log("작업 선택 창 오픈");
                    workChoose.SetActive(true);
                }
                break;
            
            case WorkMode.Forging:
                /*forgingAudioSource.PlayOneShot(forgingSound);
                forgingParticles.Play();*/
                break;
            
            case WorkMode.Smelting:
                
                break;
        }
    }
    
    //제련 오픈
    public void OnclickSmelting()
    {
        OnclickWindowClose();
        Debug.Log("제련 창 오픈");
        WorkManager(WorkMode.Smelting);
        isOtherWindow = true;
        smelter.SetActive(true);
        workChoose.SetActive(false);
    }

    //단조 오픈
    public void OnclickForging()
    {
        OnclickWindowClose();
        Debug.Log("단조 창 오픈");
        WorkManager(WorkMode.Forging);
        isOtherWindow = true;
        anvil.SetActive(true);
        workChoose.SetActive(false);
    }
    
    //인벤토리 오픈
    public void OnclickInventoryOpen()
    {
        OnclickWindowClose();
        inventory.SetActive(true);
        Debug.Log("인벤토리 오픈");
    }
    
    //세이브 오픈
    public void OnclickSaveWindowOpen()
    {
        OnclickWindowClose();
        dataSave.SetActive(true);
        Debug.Log("세이브 로드 오픈");
    }
    
    //상점 오픈
    public void OnclickShopOpen()
    {
        shopController.SetTrigger("Open");
        Debug.Log("상점 오픈");
    }
    
    //상점 닫기
    public void OnclickShopClose()
    {
        shopController.SetTrigger("Close");
        shopController.SetTrigger("Return");
        Debug.Log("상점 닫음");
    }

    //광맥 채굴티켓 구매
    public void OnclickPurchase()
    {
        if (shopItem.itemValue <= PlayerData.instance.gold)
        {
            PlayerData.instance.miningTicket++;
            PlayerData.instance.gold = PlayerData.instance.gold - shopItem.itemValue;
        }
    }
    
    //전체 창 닫기
    public void OnclickWindowClose()
    {
        foreach (var window in allWindows)
            window.SetActive(false);
        isOtherWindow = false;
        Debug.Log("창 닫음");
    }
    
    //메뉴 오픈
    public void OnclickMenuOpen()
    {
        openButton.SetActive(false);
        menuController.SetTrigger("Open");
        closeButton.SetActive(true);
        Debug.Log("메뉴 오픈");
    }
    
    //메뉴 닫기
    public void OnclickMenuClose()
    {
        closeButton.SetActive(false);
        menuController.SetTrigger("Close");
        menuController.SetTrigger("Return");
        openButton.SetActive(true);
        Debug.Log("메뉴 닫음");
    }
    
}
