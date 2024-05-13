using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelectCharacter(int index)
    {
        PlayerPrefs.SetInt("SelectionIndex", index);
        Debug.Log(PlayerPrefs.GetInt("SelectionIndex"));
    }
}
