using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] private InputField inputName;
    [SerializeField] private GameObject nameChangeUI;
    private GameObject player;
    private Text playerName;    

    private void Update()
    {
        if (inputName.text.Length >= 2 && inputName.text.Length <= 10)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }
    // TODO :: 이름 변경 중에 캐릭터 조작 안되도록 수정하기
    public void NameChange()
    {
        PlayerPrefs.SetString("PlayerName", inputName.text);
        // 태그로 찾은 플레이어 오브젝트의 자식에 접근하기
        player = GameObject.FindWithTag("Player");
        playerName = player.GetComponentInChildren<Text>();
        playerName.text = inputName.text;

        nameChangeUI.SetActive(false);
    }    
}
