using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{

    public string scenename;
    public gamemanager _gamemanager;
    void Start()
    {
        _gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gamemanager>();

    }
    public void gameplay()
    {
        SceneManager.LoadScene(scenename);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(scenename);
        }
    }
    void Update()
    {
        if (_gamemanager.collectScore >= 20)
        {
            SceneManager.LoadScene("win");
        }
    }
}
