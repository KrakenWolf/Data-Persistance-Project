using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ButtonManager : MonoBehaviour
{
    private Button start;
    private Button highscore;
    private Button exit;
    private Button backToMain;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Highscores()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void MenuBack()
    {
        SceneManager.LoadScene(0);
    }
}
