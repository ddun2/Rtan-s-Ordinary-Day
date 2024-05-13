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
    // TODO :: �̸� ���� �߿� ĳ���� ���� �ȵǵ��� �����ϱ�
    public void NameChange()
    {
        PlayerPrefs.SetString("PlayerName", inputName.text);
        // �±׷� ã�� �÷��̾� ������Ʈ�� �ڽĿ� �����ϱ�
        player = GameObject.FindWithTag("Player");
        playerName = player.GetComponentInChildren<Text>();
        playerName.text = inputName.text;

        nameChangeUI.SetActive(false);
    }    
}
