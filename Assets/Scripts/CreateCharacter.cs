using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter : MonoBehaviour
{
    [SerializeField] private GameObject selectUI;
    
    public void SelectCharacter(int index)
    {
        PlayerPrefs.SetInt("SelectionIndex", index);
        Debug.Log(PlayerPrefs.GetInt("SelectionIndex"));
        selectUI.SetActive(false);
    }
}
