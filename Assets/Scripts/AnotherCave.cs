using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherCave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3 (61.2f, 114.984f, 65.72f);   
            Destroy(gameObject);
        }
    }
}
