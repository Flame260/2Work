using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public GameObject player;
    public GameObject Enemy;
    public TextMeshProUGUI gametimer;
    public TextMeshProUGUI myscore;
    public float collectScore;
    public float Timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");  
    }

    // Update is called once per frame
    void Update()
    {
        Timer+=Time.deltaTime;
        gametimer.text = "Time:" + Mathf.Round(Timer).ToString();
        myscore.text = "score: " + collectScore.ToString();
    }
    public void addscore()
    {
        collectScore++;
    }
}
