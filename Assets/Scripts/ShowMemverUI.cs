using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMemverUI : MonoBehaviour
{
    [SerializeField] private GameObject memberUI;

    public void OpenMemberList()
    {
        memberUI.SetActive(true);
    }

    public void CloseMemberList()
    {
        memberUI.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
