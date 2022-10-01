using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelChooseAndOpen()
    {
        int curlen = gameObject.name.Length;
        string number = gameObject.name.Substring(8,curlen-9);
        int intnumber = Int16.Parse(number);
        SceneManager.LoadScene(intnumber+2);
    }
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>(); //Grabs the button component
        btn.onClick.AddListener(TaskOnClick); //Adds a listner on the button
    }
    void TaskOnClick()
    {
        int curlen = gameObject.name.Length;
        string number = gameObject.name.Substring(8, curlen - 9);
        int intnumber = Int16.Parse(number);
        SceneManager.LoadScene(intnumber + 2);
    }

    // Update is called once per frame
}
