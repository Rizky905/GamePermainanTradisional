using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Galahasin : MonoBehaviour
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

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void GoToG()
    {
        SceneManager.LoadScene("g");
    }
}
