using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public void OnShooting(InputAction.CallbackContext context)
    {
        if (!context.ReadValueAsButton())
        {
            return;
        }
        Instantiate(bullet);
    }
}
