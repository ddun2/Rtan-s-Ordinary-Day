using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] protected GameObject selectUI;
    public Sprite femaleImage;
    public Sprite maleImage;
    private Image currentImage;
    
    void Start()
    {
        currentImage = GetComponent<Image>();
    }
        
    void Update()
    {
        // 인덱스에 따라 이미지 변경
        if (PlayerPrefs.GetInt("SelectionIndex") == 0)
        {
            currentImage.sprite = maleImage;
        }

        else if(PlayerPrefs.GetInt("SelectionIndex") == 1)
        {
            currentImage.sprite = femaleImage;
        }
    }

    public void PrintSelectUI()
    {
        // 캐릭터 선택 UI 활성화
        selectUI.SetActive(true);
    }
}
