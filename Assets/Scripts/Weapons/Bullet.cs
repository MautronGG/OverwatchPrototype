using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody m_rigidBody;
    Vector3 m_myVector = new Vector3(0f, 0f, 5f);
    float m_time;
    float m_speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        m_time += Time.deltaTime;
        if ( m_time >= 1)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    public void SetDirection(Vector3 vector)
    {
        m_myVector = vector;
    }
    public void ShootBullet()
    {
        if (m_rigidBody == null)
        {
            m_rigidBody = GetComponent<Rigidbody>();
        }
        m_myVector *= m_speed;
        m_rigidBody.AddForce(m_myVector, ForceMode.Impulse);
        m_time = 0f;
    }
}
