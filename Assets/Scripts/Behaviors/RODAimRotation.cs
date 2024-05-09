using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RODAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer CharacterRenderer;

    private RODController controller;

    private void Awake()
    {
        controller = GetComponent<RODController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        Rotate(direction);
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        CharacterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
