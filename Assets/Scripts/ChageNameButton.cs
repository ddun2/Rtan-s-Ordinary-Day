using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChageNameButton : MonoBehaviour
{
    [SerializeField] private GameObject nameChangeUI;

    public void PrintUI()
    {
        nameChangeUI.SetActive(true);
    }
}
