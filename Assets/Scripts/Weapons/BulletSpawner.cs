using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BulletSpawner : MonoBehaviour
{
    public GameObject m_bullet;
    InputManager m_input;

    void Start()
    {
        m_input = SystemManager.m_instance.m_inputs;

    }
    void Update()
    {
        //if (m_input.m_shooting)

        m_input.m_shooting = InputManager.onShoot();
        if (m_input.m_shooting)
        {
            Shoot();
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