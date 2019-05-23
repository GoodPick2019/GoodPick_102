using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Scene03()
    {
        SceneManager.LoadScene("Scene03");
    }

    public void Scene01()
    {
        SceneManager.LoadScene("Scene01");
    }
}
