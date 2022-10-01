using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    public void Restart()
    {
        FindObjectOfType<Level>().RestartLevel();
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void ReplayLevel()
    {
        FindObjectOfType<Level>().RestartLevel();
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastLevel"));
    }
    public void ToInstruction()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
