using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            
        }
    }
    
}
