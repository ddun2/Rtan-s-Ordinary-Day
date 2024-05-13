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
        // �ε����� ���� �̹��� ����
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
        // ĳ���� ���� UI Ȱ��ȭ
        selectUI.SetActive(true);
    }
}
