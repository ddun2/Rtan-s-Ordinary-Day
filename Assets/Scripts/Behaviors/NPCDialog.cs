using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialog : MonoBehaviour
{
    // NPC, 대화가 다양해지면 따로 대화 데이터 저장해야함
    // NPC 마다 고유 ID도 필요할듯
    // 대화 끝내기 + 다음 대화로 넘기는 버튼

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
