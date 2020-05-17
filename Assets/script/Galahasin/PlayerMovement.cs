using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public bool leftbutton, rightbutton, upperbutton, bottombutton;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Animator animator;
    Text Infokalah;
    public GameObject Menang, Kalah;

    bool inputEnabled = false;

    // Update is called once per frame

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if ( inputEnabled == true)
        {
            if (leftbutton == true)
            {
                animator.SetBool("left", true);
                transform.Translate(Vector2.left * movespeed * Time.deltaTime);
            }

            else if (rightbutton == true)
            {
                animator.SetBool("right", true);
                transform.Translate(Vector2.right * movespeed * Time.deltaTime);
            }

            else if (bottombutton == true)
            {
                animator.SetBool("right", true);
                transform.Translate(Vector2.down * movespeed * Time.deltaTime);
            }

            else if (upperbutton == true)
            {
                animator.SetBool("right", true);
                transform.Translate(Vector2.up * movespeed * Time.deltaTime);
            }
            else
            {
                animator.SetBool("left", false);
                animator.SetBool("right", false);
            }

           /* if (nyawa == 0)
            {
                Destroy(gameObject);
                Kalah.SetActive(true);
                Time.timeScale = 0;
            }*/
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

