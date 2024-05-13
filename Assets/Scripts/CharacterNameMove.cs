using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterNameMove : MonoBehaviour
{
    private Text playerName; 
    
    private void Start()
    {
        // �ڽ� ������Ʈ�� �����ϱ�
        playerName = GetComponentInChildren<Text>();               
    }
    private void Update()
    {
        playerName.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, -1.0f, 0));
    }
}