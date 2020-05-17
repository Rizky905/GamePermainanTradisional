using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuh : MonoBehaviour
{
    public float speed;
    public float distance;
    bool Movingright = true;
    public Transform groundDetection;

    gerak KomponenGerak;

    void Start()
    {
        KomponenGerak = GameObject.Find("player").GetComponent<gerak>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (Movingright == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                Movingright = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                Movingright = true;
            }
        }
    }
        
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player"){
            KomponenGerak.nyawa--;
            KomponenGerak.ulang = true;
        }
    }

   
}
