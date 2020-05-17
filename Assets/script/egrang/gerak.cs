using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gerak : MonoBehaviour
{
    // Start is called before the first frame update

    Text infonyawa,infokoin;
         
    public int kecepatan,kekuatanLompat,pindah,nyawa,koin,finishline;
    Rigidbody2D lompat;
    public bool balik;

    public bool tanah,ulang,leftbutton,rightbutton,jumpbutton;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan;

    public GameObject Menang,Kalah;

    [SerializeField]
    GameObject player;

    Vector2 mulai;

    Animator anim;

    void Start()
    {
        lompat = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        mulai = transform.position;
        infonyawa = GameObject.Find("nyawaUI").GetComponent<Text>();
        infokoin = GameObject.Find("koinUI").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);

        infonyawa.text = (" X  ") + nyawa.ToString();
        infokoin.text = (" X  ") + koin.ToString();

        if (ulang == true)
        {
            transform.position = mulai;
            ulang = false;
        }

        if(nyawa <= 0)
        {
            Destroy(gameObject);
            Kalah.SetActive(true);
        }

        if (finishline == 1)
        {
            Destroy(gameObject);
            Menang.SetActive(true);
        }

        if (tanah == true)
        {
            anim.SetBool("lompat", false);
        }
        else
        {
            anim.SetBool("lompat", true);
        }

        if (Input.GetKey(KeyCode.D) || (rightbutton == true))
        {
            anim.SetBool("lari", true);
            transform.Translate(Vector2.right *  kecepatan * Time.deltaTime);
            pindah = -1;

        }else if (Input.GetKey(KeyCode.A) || (leftbutton == true))
        {
            anim.SetBool("lari", true);
            transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
            pindah = 1;
        }
        else
        {
            anim.SetBool("lari", false);
        }

        if (pindah > 0 && !balik)
        {
            balikbadan();
        }else if(pindah<0 && balik)
        {
            balikbadan();
        }
    }

    void balikbadan()
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }
    
    public void pressleft()
    {
        leftbutton = true;

    }
    public void releaseleft()
    {
        leftbutton = false;
    }

    public void pressright()
    {
        rightbutton = true;

    }
    public void releaseright()
    {
        rightbutton = false;
    }

    public void pressjump()
    {
        if (tanah == true)
        {
            lompat.AddForce(new Vector2(0, kekuatanLompat));
        }
    }
}
