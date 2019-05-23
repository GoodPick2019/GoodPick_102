using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class LeverManagerNew : MonoBehaviour {


    [System.Serializable]
    public class Level
    {
        public string LevelText;
        public int UnLocked;
        public bool IsInteractable;

    }

    public GameObject levelButton;
    public Transform Spacer;
    public List<Level> LevelList;


    void Start () {
        //DeleteAll();
        FillList();

    }

    void FillList()
    {
        foreach (var level in LevelList)
        {
            GameObject newbutton = Instantiate(levelButton) as GameObject;
            LevelButtonNew button = newbutton.GetComponent<LevelButtonNew>();
            button.LevelText.text = level.LevelText;
            //Level1, Level2, Level3, Level4,

            if (PlayerPrefs.GetInt("Level" + button.LevelText.text) == 1)
            {
                level.UnLocked = 1;
                level.IsInteractable = true;
            }

            button.unlocked = level.UnLocked;
            button.GetComponent<Button>().interactable = level.IsInteractable;
            button.GetComponent<Button>().onClick.AddListener(() => loadLevels("Level" + button.LevelText.text));

            if (PlayerPrefs.GetInt("Level" + button.LevelText.text + "_score") > 0)
            {
                button.Star1.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Level" + button.LevelText.text + "_score") >= 30)
            {
                button.Star2.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Level" + button.LevelText.text + "_score") >= 50)
            {
                button.Star3.SetActive(true);
            }


            newbutton.transform.SetParent(Spacer);
        }
        SaveAll();
    }

    void SaveAll()
    {
//        if (PlayerPrefs.HasKey("Level1"))
//        {
//            return;
//        }
//        else
        {
            GameObject[] allButton = GameObject.FindGameObjectsWithTag("levelButton");
            foreach (GameObject buttons in allButton)
            {
                LevelButtonNew button = buttons.GetComponent<LevelButtonNew>();
                PlayerPrefs.SetInt("Level" + button.LevelText.text, button.unlocked);
            }
        }
    }

    void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }

    void loadLevels(string value)
    {
        //Application.LoadLevel(value);
        SceneManager.LoadScene(value);
    }
}
