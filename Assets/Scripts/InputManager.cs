using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Vector2 m_movementInput = new Vector2(0f, 0f);
    public Vector2 m_looking;
    public bool m_shooting;
    public bool m_crouching;
    public bool m_jumping;

    void OnMovement(InputValue value)
    {
        m_movementInput = value.Get<Vector2>();
    }
    void OnLooking(InputValue value)
    {
        m_looking = value.Get<Vector2>();
    }
    public void OnShooting(InputValue value)
    {
        m_shooting = value.isPressed;
    }
    public void OnCrouching(InputValue value)
    {
        m_crouching = value.isPressed;
    }
    public void OnJumping(InputValue value)
    {
        m_jumping = value.isPressed;
    }
}



