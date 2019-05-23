using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{

    private Button quitButton;

    // Use this for initialization
    void Start()
    {
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}

