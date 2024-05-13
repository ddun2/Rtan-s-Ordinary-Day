using System;
using UnityEngine;

public class RODMovement : MonoBehaviour
{
    private RODController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;


    private void Awake()
    {
        movementController = GetComponent<RODController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);        
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
}