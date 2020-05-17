using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public int playerfinish;
    public GameObject Menang;
    // Start is called before the first frame update
    void Start()
    {
        /*finispos = GameObject.Find("player1").GetComponent<PlayerMovement1>();*/
/*        finispos = GameObject.Find("player2").GetComponent<PlayerMovement1>();
        finispos = GameObject.Find("player3").GetComponent<PlayerMovement1>();*/

    }

    void Update()
    {
        if (playerfinish == 3)
        {
            Menang.SetActive(true);
            Time.timeScale = 0;
        }
    }

    /*    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "player1")
            {
                finispos.FinishPos += 1;
            }
            else if (collision.tag == "player2")
            {
                finispos.FinishPos += 1;
            }
            else if (collision.tag == "player3")
            {
                finispos.FinishPos += 1;
            }
        }*/

}
