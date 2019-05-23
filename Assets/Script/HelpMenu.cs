using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void help()
    {
        SceneManager.LoadScene("Scene00");
    }
	
}
