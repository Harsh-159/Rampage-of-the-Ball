using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thanos : MonoBehaviour
{
    Level level = null;
    private void Start()
    {
        level = FindObjectOfType<Level>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject[] myNotes = GameObject.FindGameObjectsWithTag("Breakable");
        for (int i = 0; i < myNotes.Length / 2; i++)
        {
            level.RemoveBlock();
            Destroy(myNotes[i].gameObject);
        }
    }
}
