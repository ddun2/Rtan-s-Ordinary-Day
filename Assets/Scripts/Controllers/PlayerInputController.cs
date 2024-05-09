using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : RODController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 aim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(aim);
        aim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(aim);
    }
}