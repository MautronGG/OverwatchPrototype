using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    InputManager m_input;

    void Start()
    {
        m_input = SystemManager.m_instance.m_inputs;

    }
    void Update()
    {
        if (m_input.m_shooting)
        {
            Shoot();
            m_input.m_shooting = false;
        }
    }

    void Shoot()
    {
        Debug.Log("Shoot");
        Instantiate(bullet,transform.position,Quaternion.identity);
    }
}
