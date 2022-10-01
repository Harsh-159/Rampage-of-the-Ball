using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float startX = 2f;
    [SerializeField] float startY = 12f;
    public AudioClip[] myAudios;
    AudioSource myaudioSource;
    bool isLaunched = false;
    Vector3 offset;
    float change = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        paddle = FindObjectOfType<Paddle>();
        offset = transform.position - paddle.transform.position;
        myaudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunched)
        {
            transform.position = paddle.transform.position+offset;
            if (Input.GetMouseButtonDown(0))
            {
                isLaunched = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(startX, startY);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (myAudios.Length > 0)
        {
            AudioClip myClip = myAudios[Random.Range(0, myAudios.Length)];
            myaudioSource.PlayOneShot(myClip);
        }
        gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2(Random.Range(-change,change), Random.Range(-change,change));
    }
}
