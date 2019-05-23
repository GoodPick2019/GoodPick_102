using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public GameObject panel1, panel2, panel3;

    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Scene03");
    }
    public void BackButtonMenu
        ()
    {
        SceneManager.LoadScene("Scene02");
    }

    public void next()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }

    public void next1()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
    }
    public void next2()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
    }

}
