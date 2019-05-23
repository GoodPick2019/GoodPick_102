using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class LibraryContent : MonoBehaviour {

    public GameObject content1, page1_1, page2_1, page3_1;
    public GameObject content2, page1_2, page2_2, page3_2;
    public GameObject content3, page1_3, page2_3, page3_3;
    public GameObject content4, page1_4, page2_4, page3_4;
    public GameObject content5, page1_5, page2_5, page3_5;
    public GameObject content6, page1_6, page2_6, page3_6;

    // Use this for initialization
    void Start ()
    {
		content1.SetActive(false);
    }
	
    public void Lesson1()
    {
        content1.SetActive(true);
        page1_1.SetActive(true);
        page2_1.SetActive(false);
        page3_1.SetActive(false);
    }
    public void next1_1()
    {
        page2_1.SetActive(true);
        page1_1.SetActive(false);
        page3_1.SetActive(false);
    }
    public void next2_1()
    {
        page3_1.SetActive(true);
        page1_1.SetActive(false);
        page2_1.SetActive(false);
    }
    public void next3_1()
    {
        content1.SetActive(false);
    }

    public void Lesson2()
    {
        content2.SetActive(true);
        page1_2.SetActive(true);
        page2_2.SetActive(false);
        page3_2.SetActive(false);
    }
    public void next1_2()
    {
        page2_2.SetActive(true);
        page1_2.SetActive(false);
        page3_2.SetActive(false);
    }
    public void next2_2()
    {
        page3_2.SetActive(true);
        page1_2.SetActive(false);
        page2_2.SetActive(false);
    }
    public void next3_2()
    {
        content2.SetActive(false);
    }

    public void Lesson3()
    {
        content3.SetActive(true);
        page1_3.SetActive(true);
        page2_3.SetActive(false);
        page3_3.SetActive(false);
    }
    public void next1_3()
    {
        page2_3.SetActive(true);
        page1_3.SetActive(false);
        page3_3.SetActive(false);
    }
    public void next2_3()
    {
        page3_3.SetActive(true);
        page1_3.SetActive(false);
        page2_3.SetActive(false);
    }
    public void next3_3()
    {
        content3.SetActive(false);
    }

    public void Lesson4()
    {
        content4.SetActive(true);
        page1_4.SetActive(true);
        page2_4.SetActive(false);
        page3_4.SetActive(false);
    }
    public void next1_4()
    {
        page2_4.SetActive(true);
        page1_4.SetActive(false);
        page3_4.SetActive(false);
    }
    public void next2_4()
    {
        page3_4.SetActive(true);
        page1_4.SetActive(false);
        page2_4.SetActive(false);
    }
    public void next3_4()
    {
        content4.SetActive(false);
    }

    public void Lesson5()
    {
        content5.SetActive(true);
        page1_5.SetActive(true);
        page2_5.SetActive(false);
        page3_5.SetActive(false);
    }
    public void next1_5()
    {
        page2_5.SetActive(true);
        page1_5.SetActive(false);
        page3_5.SetActive(false);
    }
    public void next2_5()
    {
        page3_5.SetActive(true);
        page1_5.SetActive(false);
        page2_5.SetActive(false);
    }
    public void next3_5()
    {
        content5.SetActive(false);
    }

    public void Lesson6()
    {
        content6.SetActive(true);
        page1_6.SetActive(true);
        page2_6.SetActive(false);
        page3_6.SetActive(false);
    }
    public void next1_6()
    {
        page2_6.SetActive(true);
        page1_6.SetActive(false);
        page3_6.SetActive(false);
    }
    public void next2_6()
    {
        page3_6.SetActive(true);
        page1_6.SetActive(false);
        page2_6.SetActive(false);
    }
    public void next3_6()
    {
        content6.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
