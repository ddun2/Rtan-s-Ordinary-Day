using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterNameMove : MonoBehaviour
{
    //[SerializeField] private Text playerName;
    private GameObject Name; 
    private Text playerName;

    private void Start()
    {
        Name = transform.GetChild(1).GetChild(0).gameObject;
        //playerName = Name.GetComponent<Text>();
        Debug.Log(Name.name);
        
    }
    private void Update()
    {
       Name.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, -1.0f, 0));
    }
}
