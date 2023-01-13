using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody m_rigidBody;
    Vector3 m_myVector = new Vector3(0f, 0f, 10f);
    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody>();
        m_rigidBody.AddForce(m_myVector,ForceMode.Impulse);
    }
}
