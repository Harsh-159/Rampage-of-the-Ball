using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int playerScore;
    [SerializeField] TextMeshProUGUI myScore=null;
    float slowSpeed = 0.5f;
    float normalSpeed = 1f;
    float fastSpeed = 2f;
    // Start is called before the first frame update

    public void Start()
    {
        updateScore();
    }

    private void updateScore()
    {
        myScore.text = playerScore.ToString();
    }

    public void AddBlock()
    {
        breakableBlocks++;
        updateScore();
    }
    public void RemoveBlock()
    {
        breakableBlocks--;
        playerScore += Random.Range(50, 60);
        updateScore();
    }
    private void Update()
    {
        Time.timeScale = gameSpeed;
        if ((breakableBlocks == 0)&&(SceneManager.GetActiveScene().name!="You Lose")&&(SceneManager.GetActiveScene().name != "You Win"))
        {
            if (SceneManager.GetActiveScene().name=="Last Level")
            {
                SceneManager.LoadScene("You Win");
            }
            else
            {
                int currentScene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentScene + 1);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameSpeed = slowSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameSpeed = normalSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameSpeed = fastSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            RestartLevel();
            SceneManager.LoadScene("StartScene");
        }
    }
    public void RestartLevel()
    {
        Destroy(gameObject);
    }
}
