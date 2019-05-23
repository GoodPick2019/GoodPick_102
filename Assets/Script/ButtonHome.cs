using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHome : MonoBehaviour
{

    public void BackButton()
    {
        SceneManager.LoadScene("Scene02");
    }
}
