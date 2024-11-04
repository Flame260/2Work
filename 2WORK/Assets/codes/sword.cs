using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    private Animator ani;
    private bool isClicking = false;
    public GameObject hitboxPrefab;
    private GameObject currentHitbox;
    private bool hit;

    void Start()
    {
        ani=GetComponent<Animator>();
        
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Click();
            isClicking = true;
            currentHitbox.transform.position=transform.position;
        }
        else if (Input.GetMouseButtonUp(0) && isClicking)
        {
            Not();
            isClicking = true;
        }
    }
    void FixedUpdate()
    {

    }
    //slahing animation
    void Click()
    {
        ani.SetTrigger("slash");
        ActivateHitbox();
    }
    void Not()
    {
        ani.SetTrigger("nothing");
        DeactivateHitbox();
    }
    void ActivateHitbox()
    {
        if (currentHitbox == null)
        {
            currentHitbox = Instantiate(hitboxPrefab, transform.position, transform.rotation); 
            currentHitbox.transform.SetParent(transform); 
        }

    }
    void DeactivateHitbox()
    {
        if (currentHitbox != null)
        {
            Destroy(currentHitbox); 
            currentHitbox = null;
        }
    }
    

}
