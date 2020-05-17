using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    gerak Finish;

    void Start()
    {
        Finish = GameObject.Find("player").GetComponent<gerak>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            Finish.finishline++;
            Destroy(gameObject);
        }
    }
}
