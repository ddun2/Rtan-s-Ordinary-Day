using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject character_Male;
    public GameObject character_Female;
    //public GameObject player;
    [SerializeField] private Text playerName;

    //public int index;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        //playerName.text = PlayerPrefs.GetString("PlayerName");
        
        //index = PlayerPrefs.GetInt("SelectionIndex");
    }

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("SelectionIndex") == 0)
        {
            GameObject player = Instantiate(character_Male);
        }
        else if(PlayerPrefs.GetInt("SelectionIndex") == 1)
        {
            GameObject player = Instantiate(character_Female);
        }
        
        //switch (index)
        //{
        //    case 0:
        //        player = Instantiate(character_Male);
        //        break;
        //    case 1:
        //        player = Instantiate(character_Male);
        //        break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
