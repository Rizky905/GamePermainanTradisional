using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pletokan : MonoBehaviour
{
    public GameObject informasi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Informasi()
    {
        informasi.SetActive(true);
    }

    public void Back()
    {
        informasi.SetActive(false);
    }
}
