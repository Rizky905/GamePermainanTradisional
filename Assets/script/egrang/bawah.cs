using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bawah : MonoBehaviour
{
    gerak bawahtanah;

    // Start is called before the first frame update
    void Start()
    {
        bawahtanah = GameObject.Find("player").GetComponent<gerak>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            bawahtanah.nyawa--;
            bawahtanah.ulang = true;
        }
    }
}
