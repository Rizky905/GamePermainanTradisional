using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public bool leftbutton, rightbutton, upperbutton, bottombutton;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Animator animator;
    /*public GameObject Menang, Kalah;*/
/*    public int nyawa,FinishPos;*/

    bool inputEnabled = false;

    finishline PlayerFinish;

    // Start is called before the first frame update
    void Start()
    {
        PlayerFinish = GameObject.Find("finishline").GetComponent<finishline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputEnabled == true)
        {
            if (leftbutton == true)
            {

                transform.Translate(Vector2.left * movespeed * Time.deltaTime);
            }

            else if (rightbutton == true)
            {
                
                transform.Translate(Vector2.right * movespeed * Time.deltaTime);
            }

            else if (bottombutton == true)
            {
                
                transform.Translate(Vector2.down * movespeed * Time.deltaTime);
            }

            else if (upperbutton == true)
            {
                transform.Translate(Vector2.up * movespeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "finishline")
        {
            PlayerFinish.playerfinish++;
        }
    }

    public void active()
    {
        inputEnabled = true;
    }
    public void deactive()
    {
        inputEnabled = false;
    }

    public void pressleft()
    {
        leftbutton = true;
    }
    public void realeseleft()
    {
        leftbutton = false;
    }
    public void pressright()
    {
        rightbutton = true;
    }
    public void realeaseright()
    {
        rightbutton = false;
    }
    public void pressdown()
    {
        bottombutton = true;
    }
    public void realeasedown()
    {
        bottombutton = false;
    }
    public void pressup()
    {
        upperbutton = true;
    }
    public void realeaseup()
    {
        upperbutton = false;
    }

}
