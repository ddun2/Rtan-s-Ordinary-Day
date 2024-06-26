using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected GameObject Characters;
    public static GameManager instance;
    public GameObject character_Male;
    public GameObject character_Female;
    public GameObject player;
    private Text playerName;
    
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        // 캐릭터 생성
        if (PlayerPrefs.GetInt("SelectionIndex") == 0)
        {
            // 인덱스에 따라 캐릭터 오브젝트 생성 후 이름 설정
            player = Instantiate(character_Male);
            // Characters 오브젝트의 자식으로 생성
            player.transform.SetParent(Characters.transform);
            playerName = player.GetComponentInChildren<Text>();
            playerName.text = PlayerPrefs.GetString("PlayerName");
        }
        else if (PlayerPrefs.GetInt("SelectionIndex") == 1)
        {
            player = Instantiate(character_Female);
            player.transform.SetParent(Characters.transform);
            playerName = player.GetComponentInChildren<Text>();
            playerName.text = PlayerPrefs.GetString("PlayerName");
        }
    }
        
    void Start()
    {
               
    }
}
