using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ironMan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Level level = FindObjectOfType<Level>();
        level.RestartLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
