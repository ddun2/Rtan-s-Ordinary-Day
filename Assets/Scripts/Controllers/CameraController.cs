using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //[SerializeField] private Transform player;
    Transform GameObject;

    private void Awake()
    {
        // TODO :: ���߿� �����պ��� ���� ���� ����
        GameObject = GameManager.instance.playerMale.transform;
    }

    private void FixedUpdate()
    {
        Vector3 playerPos = new Vector3(GameObject.position.x, GameObject.position.y, this.transform.position.z);
        transform.position = playerPos;
    }
}
