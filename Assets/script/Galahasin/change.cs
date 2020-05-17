using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{

    public GameObject playerone, playertwo, playerthree, Lingkaran1, Lingkaran2, Lingkaran3;
    public bool changeplayer1butt, changeplayer2butt, changeplayer3butt;

    // Start is called before the first frame update
    void Start()
    {
        /*playerone = GameObject.Find("player1");
        playertwo = GameObject.Find("player2");*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || (changeplayer1butt == true))
        {
            playerone.gameObject.SendMessage("active");
            playertwo.gameObject.SendMessage("deactive");
            playerthree.gameObject.SendMessage("deactive");
            Lingkaran1.SetActive(true);
            Lingkaran2.SetActive(false);
            Lingkaran3.SetActive(false);

        }

        else if (Input.GetKeyDown(KeyCode.D) || (changeplayer2butt == true))
        {
            playertwo.gameObject.SendMessage("active");
            playerone.gameObject.SendMessage("deactive");
            playerthree.gameObject.SendMessage("deactive");
            Lingkaran2.SetActive(true);
            Lingkaran1.SetActive(false);
            Lingkaran3.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.D) || (changeplayer3butt == true))
        {
            playerthree.gameObject.SendMessage("active");
            playerone.gameObject.SendMessage("deactive");
            playertwo.gameObject.SendMessage("deactive");
            Lingkaran3.SetActive(true);
            Lingkaran2.SetActive(false);
            Lingkaran1.SetActive(false);
        }
    }

    public void change1()
    {
        changeplayer1butt = true;
    }
    public void change1re()
    {
        changeplayer1butt = false;
    }

    public void change2()
    {
        changeplayer2butt = true;
    }
    public void change2re()
    {
        changeplayer2butt = false;
    }
    public void change3()
    {
        changeplayer3butt = true;
    }
    public void change3re()
    {
        changeplayer3butt = false;
    }
}
