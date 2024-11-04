using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public GameObject ememy;
    public int maxhealth = 100;
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
    }

     public void TakeDamage(int amount)
    {
        currenthealth -= amount; 

        if (currenthealth <= 0) 
        {
            death();
        }
    }
    void death()
    {
        Debug.Log(gameObject.name + " has died.");
        
    }
}
