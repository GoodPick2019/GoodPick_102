using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Helper;
using Level;

public class ProfileSystem : MonoBehaviour {

    public Text Displayname;
    public Text HighScore;

    // Use this for initialization
    void Start () {
        //DCF_DemoScene_ManagerScript_CSharp name1 = new DCF_DemoScene_ManagerScript_CSharp();
        //var name = GameObject.Find("playUsername").GetComponent(" DCF_DemoScene_ManagerScript_CSharp");


        Displayname.text = DCF_DemoScene_ManagerScript_CSharp.ID;
        Debug.Log("Welcome Username: " + DCF_DemoScene_ManagerScript_CSharp.ID);
        //HighScore.text = level02.score02;
        //HighScore.text = level4.score04;
        //HighScore.text = level03.score03;

        //Debug.Log("HighScore: " + level01.hScore);

    }

}
