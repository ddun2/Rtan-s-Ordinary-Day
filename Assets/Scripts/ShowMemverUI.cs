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

    // ������ ��� ǥ��
    public void OpenMemberList()
    {
        memberUI.SetActive(true);

        // ĳ���� �̸� ���� �Ŀ��� �����Ű�� ����
        // ��ư Ŭ�� �� nameList �ʱ�ȭ
        // TODO :: ���ΰ�ħ ��ư �����

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
