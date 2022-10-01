using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] AudioClip audioClip=null;
    Level level;
    [SerializeField] int health=3;
    [SerializeField] Sprite[] hitSprites=null;
    int noOfHits = 0;
    ParticleSystem.MainModule ps;
    private void Start()
    {
        ps = gameObject.GetComponent<ParticleSystem>().main;
        ps.startColor = gameObject.GetComponent<SpriteRenderer>().color;
        if (tag == "Breakable")
        {
            level = FindObjectOfType<Level>();
            level.AddBlock();
        }
        
    }
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position);
        if (tag == "Breakable")
        {
            noOfHits++;
            if (health <= noOfHits)
            {
                level.RemoveBlock();
                gameObject.GetComponent<ParticleSystem>().Play();
                Destroy(gameObject.GetComponent<SpriteRenderer>());
                Destroy(gameObject.GetComponent<BoxCollider2D>());
                Destroy(gameObject, 1f);
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = hitSprites[noOfHits];
            }
            
        }
        
    }
}
