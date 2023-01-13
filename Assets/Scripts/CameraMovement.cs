using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public float speedmov = 10f;
    public float speedrot = 100f;
    public float Yaw = 0f;
    public float pitch = 0f;
    public PlayerInput m_playerInput;
    //public Vector3 rotate = new Vector3(1f,0f,0f); 
    // Start is called before the first frame update
    void Start()
    {
        m_playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementInput = m_playerInput.actions["Movement"].ReadValue<Vector2>();

        Yaw += Input.GetAxis("Mouse X")  * speedrot;
        pitch -= Input.GetAxis("Mouse Y")  * speedrot;
        pitch = Mathf.Clamp(pitch, -50, 50);

        transform.rotation = Quaternion.Euler(pitch, Yaw, 0f);

    }
}
