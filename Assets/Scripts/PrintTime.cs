using System;
using UnityEngine;
using UnityEngine.UI;

public class PrintTime : MonoBehaviour
{
    [SerializeField] private Text time;
    
    public void Update()
    {
        time.text = DateTime.Now.ToString("t");
    }
}