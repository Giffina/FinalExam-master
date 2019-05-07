using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void First()
    {
        SceneManager.LoadScene("2HighScores");
    }
    public void Second()
    {
        SceneManager.LoadScene("3Game");
    }
    public void Third()
    {
        SceneManager.LoadScene("4Exit");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene("1Intro");
    }
}