using Unity.VisualScripting;
using UnityEngine;

public class ChangeCharacter : SelectCharacter
{
    public void Change(int index)
    {
        // 캐릭터 인덱스 변경
        PlayerPrefs.SetInt("SelectionIndex", index);
        Debug.Log(PlayerPrefs.GetInt("SelectionIndex"));

        // 캐릭터 이미지 변경
        //GameManager.instance.player
        selectUI.SetActive(false);
    }
}
