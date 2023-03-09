using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject m_door;
    void Start()
    {
        m_door.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_door.SetActive(true);
            Destroy(gameObject);
        }
    }
}
