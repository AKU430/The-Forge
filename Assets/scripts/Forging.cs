using UnityEngine;
using TMPro;

public class Forging : MonoBehaviour
{
    [Header("파티클 및 오디오 설정")]
    [Tooltip("단조 효과로 사용할 파티클")] public ParticleSystem forgingParticles;
    [Tooltip("UI 전환 애니메이터")] public Animator menuController;
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
    [Tooltip("제련, 단조 작업 선택 오브젝트")] public GameObject workChoose;
    [Tooltip("제련 작업 오브잭트")] public GameObject smelter;
    [Tooltip("단조 작업 오브잭트")] public GameObject anvil;

    public void WorkManager(string mode)
    {
        //작업 선택
        if (mode == "작업 선택")
        {
            Debug.Log("작업 선택 창 오픈");
            workChoose.SetActive(true);
        }
        //단조
        else if (mode == "단조 선택 됨")
        {
            forgingAudioSource.PlayOneShot(forgingSound);
            forgingParticles.Play();
        }
        //제련
        else if (mode == "제련 선택 됨")
        {
            
        }
    }

    public void OnclickSmelting()
    {
        OnclickWindowClose();
        Debug.Log("제련 창 오픈");
        WorkManager("제련 선택됨");
        smelter.SetActive(true);
        workChoose.SetActive(false);
    }

    public void OnclickForging()
    {
        OnclickWindowClose();
        Debug.Log("단조 창 오픈");
        WorkManager("단조 선택됨");
        anvil.SetActive(true);
        workChoose.SetActive(false);
    }
    
    //창 열고 닫음
    public void OnclickInventoryOpen()
    {
        OnclickWindowClose();
        inventory.SetActive(true);
        Debug.Log("인벤토리 오픈");
    }
    
    public void OnclickSaveWindowOpen()
    {
        OnclickWindowClose();
        dataSave.SetActive(true);
        Debug.Log("세이브 로드 오픈");
    }
    
    public void OnclickWindowClose()
    {
        anvil.SetActive(false);
        smelter.SetActive(false);
        workChoose.SetActive(false);
        inventory.SetActive(false);
        dataSave.SetActive(false);
            Debug.Log("창 닫음");
    }
    
    public void OnclickMenuOpen()
    {
        openButton.SetActive(false);
        menuController.SetTrigger("Open");
        closeButton.SetActive(true);
        Debug.Log("메뉴 오픈");
    }
    
    public void OnclickMenuClose()
    {
        closeButton.SetActive(false);
        menuController.SetTrigger("Close");
        menuController.SetTrigger("Return");
        openButton.SetActive(true);
        Debug.Log("메뉴 닫음");
    }
}
