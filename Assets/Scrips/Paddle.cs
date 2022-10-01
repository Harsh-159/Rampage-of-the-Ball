using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float unitsX = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    // Update is called once per frame
    void Update()
    {
        float curMouseX = (Input.mousePosition.x / Screen.width) * unitsX;
        curMouseX=Mathf.Clamp(curMouseX, minX, maxX);
        Vector2 newPos = new Vector2(curMouseX, transform.position.y);
        transform.position = newPos;
    }
}
