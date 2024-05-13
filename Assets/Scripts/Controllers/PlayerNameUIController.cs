using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameUIController : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void FixedUpdate()
    {
        Vector3 playerPos = new Vector3(GameManager.instance.character_Male.transform.position.x, player.position.y, this.transform.position.z);
        transform.position = playerPos;
    }
}
