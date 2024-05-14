using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{    
    static GameObject player;

    private void Start()
    {
        // 태그로 플레이어 찾기
        player = GameObject.FindWithTag("Player");
    }

    public static void SetPlayer()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        transform.position = playerPos;
    }
}
