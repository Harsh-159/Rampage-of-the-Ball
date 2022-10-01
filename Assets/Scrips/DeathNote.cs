using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DeathNote : MonoBehaviour
{
    private Note[] myNotes;
    int blockToBeDestroyed = 0;
    Level level=null;
    // Start is called before the first frame update
    void Start()
    {
        myNotes = FindObjectsOfType<Note>();
        level = FindObjectOfType<Level>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        level.RemoveBlock();
        Destroy(myNotes[blockToBeDestroyed].gameObject);
        blockToBeDestroyed++;
    }
}
