using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour {

    public void Restar()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Restarlvl2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Restarlvl3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Restarlvl4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Library()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Scene03");
    }
}
