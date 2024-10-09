using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed=2f;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = GetMovement()* speed  
    }
    Vector3 GetMovement()
    {
        float xmove = Input.GetAxis("Horizontal");
        float ymove = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(xmove, 0, ymove);
        Debug.DrawRay(transform.position,rb.velocity,Color.blue);
        Debug.DrawRay(transform.position,move*2,Color.red);
        return move; 
    }
}
