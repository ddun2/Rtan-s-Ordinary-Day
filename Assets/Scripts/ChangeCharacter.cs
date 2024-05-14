using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore.Text;

public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject selectUI;
    [SerializeField] private GameObject Characters;
    private GameObject currentCharacter;
    private Vector3 currentCharacterPos;
    public GameObject character_Male;
    public GameObject character_Female;
    public GameObject player;
    private Text playerName;

    private void Start()
    {
        
    }

    // 캐릭터 선택 UI 활성화
    public void PrintSelectUI()
    {       
        selectUI.SetActive(true);
    }

    public void Change(int index)
    {
        // 현재 캐릭터 데이터 가져오기
        currentCharacter = GameObject.FindWithTag("Player");
        currentCharacterPos = currentCharacter.transform.position;

        // 현재 캐릭터 삭제
        currentCharacter.SetActive(false);

        // 인덱스에 따라 캐릭터 오브젝트 재생성
        if (index == 0)
        {
            player = Instantiate(character_Female);
            PlayerPrefs.SetInt("SelectionIndex", 1);
        }
        else
        {
            player = Instantiate(character_Male);
            PlayerPrefs.SetInt("SelectionIndex", 0);
        }
        // Characters 오브젝트의 자식으로 생성
        player.transform.SetParent(Characters.transform);
        // 스폰 위치 설정
        player.transform.position = currentCharacterPos;
        // 이름 설정
        playerName = player.GetComponentInChildren<Text>();
        playerName.text = PlayerPrefs.GetString("PlayerName");

        Destroy(currentCharacter);
        CameraController.SetPlayer();

        selectUI.SetActive(false);
    }
}
