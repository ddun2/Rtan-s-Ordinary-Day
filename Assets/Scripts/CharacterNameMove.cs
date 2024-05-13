using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterNameMove : MonoBehaviour
{    
    private GameObject playerName; 

    private void Start()
    {        
        // 자식 오브젝트에 접근하기
        playerName = transform.GetChild(1).GetChild(0).gameObject;
    }
    private void Update()
    {
       playerName.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, -1.0f, 0));
    }
}