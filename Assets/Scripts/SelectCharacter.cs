using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] private GameObject selectUI;
    public Sprite femaleImage;
    public Sprite maleImage;
    private Image currentImage;
    // Start is called before the first frame update
    void Start()
    {
        currentImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
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
        selectUI.SetActive(true);
    }
}
