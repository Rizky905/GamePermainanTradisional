using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sungai : MonoBehaviour
{
    gerak deteksisungai;

    // Start is called before the first frame update
    void Start()
    {
        deteksisungai = GameObject.Find("player").GetComponent<gerak>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            deteksisungai.nyawa--;
            deteksisungai.ulang = true;
        }
    }
}
