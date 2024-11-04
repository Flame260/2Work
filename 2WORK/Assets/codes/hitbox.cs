using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{
    public gamemanager _gamemanager;
    void start()
    {
        _gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gamemanager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Enemy")
        {
            _gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gamemanager>();
            Destroy(other.gameObject);
            _gamemanager.AddScore();
            
        }
    }
    
    
}
