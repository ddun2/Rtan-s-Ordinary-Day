using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private InputField inputName;

    private void Update()
    {
        if(inputName.text.Length >= 2 && inputName.text.Length <= 10)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
        PlayerPrefs.SetString("PlayerName", inputName.text);
    }
}
