using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public float walkSpeed = 10f;
    
    Vector2 movementInput;
    Rigidbody m_rigidbody;

    
    //public Vector3 rotate = new Vector3(1f,0f,0f); 
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 movementInput = m_playerInput.actions["Movement"].ReadValue<Vector2>();
        Moving();
        
    }
    void Moving()
    {
        Vector3 playerVelocity = new Vector3(movementInput.x * walkSpeed, m_rigidbody.velocity.y, movementInput.y * walkSpeed);
        m_rigidbody.velocity = transform.TransformDirection(playerVelocity);
    }
    void OnMovement(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }
}
