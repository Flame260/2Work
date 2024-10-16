using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed=10f;
    public float jumpforce = 10f;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void FixedUpdate()
    {
        Vector3 aimDir = transform.TransformDirection(GetMovement());
        rb.AddForce(aimDir * speed);

    }


    Vector3 GetMovement()
    {
        float xmove = Input.GetAxis("Horizontal");
        float zmove = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(xmove, 0, zmove);
       
        Debug.DrawRay(transform.position,rb.velocity,Color.blue);
        Debug.DrawRay(transform.position,move*2,Color.red);
        return move; 
    }
}
