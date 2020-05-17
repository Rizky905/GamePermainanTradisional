using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusuhAI : MonoBehaviour
{

    public float MoveSpeed;
    private float WaitTime;
    public float StartWaitTime;

    public Transform[] MoveSpots;
    private int randomspot;

    PlayerMovement1 DeteksiBadan;
    PlayerMovement1 DeteksiBadan1;

    public GameObject Menang, Kalah;

    // Start is called before the first frame update
    void Start()
    {
        DeteksiBadan = GameObject.Find("player1").GetComponent<PlayerMovement1>();
/*        DeteksiBadan1 = GameObject.Find("player2").GetComponent<PlayerMovement1>();*/
        
        WaitTime = StartWaitTime;
        randomspot = Random.Range(0, MoveSpots.Length);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, MoveSpots[randomspot].position, MoveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, MoveSpots[randomspot].position) < 0.25f)
        {
            if (WaitTime <= 0)
            {
                randomspot = Random.Range(0, MoveSpots.Length);
                WaitTime = StartWaitTime;
            }
            else
            {
                WaitTime -= Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
/*        if (other.transform.tag == "player1")
        {
            Kalah.SetActive(true);
            Time.timeScale = 0;
        }*/
/*
        else if (other.transform.tag == "player2")
        {
            Kalah.SetActive(true);
            Time.timeScale = 0;
        }*/
    }
}
