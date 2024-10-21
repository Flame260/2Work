using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector3 mylook;
    public Camera mycam;
    public float camlock = 90f;
    float lookspeed = 200f;
    float onstarttimer;
    // Start is called before the first frame update
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mylook = transform.localEulerAngles;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onstarttimer += Time.deltaTime;
        mylook += Deltalook()*Time.deltaTime*lookspeed;
        mylook.y = Mathf.Clamp(mylook.y, -camlock, camlock);
        transform.rotation = Quaternion.Euler(0f, mylook.x, 0f);

        mycam.transform.rotation = Quaternion.Euler(-mylook.y, mylook.x, 0f);
    }
    Vector3 Deltalook()
    {
        Vector3 dlook;
        float roty = Input.GetAxis("Mouse Y");
        float rotx = Input.GetAxis("Mouse X");
        dlook= new Vector3(rotx, roty, 0);
       
        if(onstarttimer <1f)
        {
            dlook = Vector3.ClampMagnitude(dlook,onstarttimer);
        }
        return dlook;
    }
}
