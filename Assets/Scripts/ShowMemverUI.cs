using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMemverUI : MonoBehaviour
{
    [SerializeField] private GameObject memberUI;
    [SerializeField] private GameObject characters;
    [SerializeField] private Text printName;
    
    private Text[] nameList;

    // 참석자 명단 표시
    public void OpenMemberList()
    {
        memberUI.SetActive(true);

        // 캐릭터 이름 변경 후에도 적용시키기 위해
        // 버튼 클릭 시 nameList 초기화
        // TODO :: 새로고침 버튼 만들기

        printName.text = "";
        nameList = characters.GetComponentsInChildren<Text>();
        for(int i = 0; i < nameList.Length; i++)
        {
            printName.text += nameList[i].text + "\n";
        }
        
    }

    public void CloseMemberList()
    {
        memberUI.SetActive(false);
    }
}
