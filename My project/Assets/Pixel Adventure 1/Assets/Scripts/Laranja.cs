using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laranja : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
        
    public int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
           
            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();

            Destroy(gameObject);

        }
    }
}
