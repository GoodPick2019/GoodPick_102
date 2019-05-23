using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GuidelinesMenu : MonoBehaviour {

    public RectTransform guide1,guide2,guide3;

    // Use this for initialization
    void Start () {
        
    }
    public void helpbtn()
    {
        guide1.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void next1()
    {
        guide2.DOAnchorPos(new Vector2(0, 0), 0.25f);
        guide1.DOAnchorPos(new Vector2(-842, 0), 0.25f);

    }
    public void next2()
    {
        guide3.DOAnchorPos(new Vector2(0, 0), 0.25f);
        guide2.DOAnchorPos(new Vector2(-842, 0), 0.25f);
        guide1.DOAnchorPos(new Vector2(-1641, 0), 0.25f);
    }
    public void skip()
    {
        guide3.DOAnchorPos(new Vector2(2464, 0), 0.25f);
        guide2.DOAnchorPos(new Vector2(1622, 0), 0.25f);
        guide1.DOAnchorPos(new Vector2(823, 0), 0.25f);
    }
}
