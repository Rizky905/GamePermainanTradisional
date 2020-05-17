using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burung : MonoBehaviour
{
    public float speed;
    public bool MoveRight;

    gerak KomponenGerak;

    void Start()
    {
        KomponenGerak = GameObject.Find("player").GetComponent<gerak>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2 (-0.2f , 0.2f);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(0.2f, 0.2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            KomponenGerak.nyawa--;
            KomponenGerak.ulang = true;
        }
    }
}
