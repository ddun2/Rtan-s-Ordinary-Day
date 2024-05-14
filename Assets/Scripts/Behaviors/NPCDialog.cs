using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialog : MonoBehaviour
{
    // NPC, ��ȭ�� �پ������� ���� ��ȭ ������ �����ؾ���
    // NPC ���� ���� ID�� �ʿ��ҵ�
    // ��ȭ ������ + ���� ��ȭ�� �ѱ�� ��ư

    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private GameObject dialogTriggerPanel;

    public void StartDialog()
    {
        dialogTriggerPanel.SetActive(false);
        dialogPanel.SetActive(true);
    }

    public void EndDialog()
    {
        dialogPanel.SetActive(false);
    }
}
