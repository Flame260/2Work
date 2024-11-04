using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{
    public Gamemanager gamemanager;
    void start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gamemanager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            gamemanager.AddScore();
            
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            gamemanager.AddScore();
            
        }
    }
    
}
