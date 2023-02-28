using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Vector2 m_movementInput = new Vector2(0f, 0f);
    public Vector2 m_looking;
    public bool m_shooting;
    static bool m_shooting2;
    public bool m_crouching;
    public bool m_jumping;
    public bool m_isPause;
    public bool m_pausing = false;
    static PlayerInput m_playerInput;
    GameObject m_pauseCanvas;

    private void Awake()
    {
        m_pauseCanvas = GameObject.FindGameObjectWithTag("Pause");
        m_pauseCanvas.SetActive(false);
    }
    private void Start()
    {
        m_playerInput = GetComponent<PlayerInput>();
    }

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
        //m_shooting = value.isPressed;
    }
    public void OnCrouching(InputValue value)
    {
        m_crouching = value.isPressed;
    }
    public void OnJumping(InputValue value)
    {
        m_jumping = value.isPressed;
    }
    public void OnPause(InputValue value)
    {
        m_isPause = value.isPressed;
    }

    static public bool onShootRelased()
    {

        return m_playerInput.actions.FindAction("Shooting").WasReleasedThisFrame();
    }

    static public bool onShootRPressed()
    {
        return m_playerInput.actions.FindAction("Shooting").WasPressedThisFrame();
    }

    static public bool onShoot()
    {
        if (!m_shooting2)
        {
            m_shooting2= m_playerInput.actions.FindAction("Shooting").WasPressedThisFrame();
        }
        else if (m_shooting2 && m_playerInput.actions.FindAction("Shooting").WasReleasedThisFrame())
        {
            m_shooting2 = false;
        }
        return m_shooting2;
    }
    void Update()
    {
        Pausing();
    }
    private void Pausing()
    {
        if (m_isPause)
        {
            m_pausing = true;
            Time.timeScale = 0f;
            m_pauseCanvas.SetActive(true);
        }
    }
}




