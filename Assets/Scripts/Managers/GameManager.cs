using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject playerMale;
    public GameObject character_Female;
    [SerializeField] private Text playerName;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        playerName.text = PlayerPrefs.GetString("PlayerName");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("DF");  
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
