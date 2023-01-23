using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BulletSpawner : MonoBehaviour
{
    public GameObject m_bullet;
    InputManager m_input;
    float m_firerate = 0f;
    void Start()
    {
        m_input = SystemManager.m_instance.m_inputs;

    }
    void Update()
    {
        //if (m_input.m_shooting)
        m_firerate += Time.deltaTime;
        m_input.m_shooting = InputManager.onShoot();
        if (m_input.m_shooting && m_firerate >= 0.10f)
        {
            Shoot();
            m_firerate = 0f;
        }
        //if (InputManager.onShootRPressed())
        //{
        //    Shoot();
        //    m_input.m_shooting = false;
        //    InputManager.onShootRelased();
        //}
    }

    void Shoot()
    {
        Debug.Log("Shoot");
        var bullet = Instantiate(m_bullet,transform.position,Quaternion.identity).GetComponent<Bullet>();
        bullet.SetDirection(Camera.main.transform.forward);
        bullet.ShootBullet();
    }
}