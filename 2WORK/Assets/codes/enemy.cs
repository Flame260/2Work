using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public int damageAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.transform.position - transform.position;
            direction.Normalize(); 
            transform.position += direction * speed * Time.deltaTime;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }

    }
    private void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            health currenthealth = collision.gameObject.GetComponent<health>();
            if (currenthealth != null) // Ensure the player has a Health component
            {
                currenthealth.TakeDamage(damageAmount); // Apply damage to the player
                Debug.Log("Player took damage: " + damageAmount);
            }
        }
    }
}
