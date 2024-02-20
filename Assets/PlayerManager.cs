using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerManager : MonoBehaviour
{

    public int score = 0;
    public TextMeshProUGUI scoretracker;
    EnemyAgroZone agroZone;
    MoveTowards moveTowards;

    // Start is called before the first frame update
    void Start()
    {
       agroZone = GetComponent<EnemyAgroZone>();
        moveTowards = GetComponent<MoveTowards>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretracker.text = "Score: " + score;
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Collectable")
        {
            score++;
            Debug.Log("Collided with " + collision.collider.name);
            Destroy(collision.gameObject);
        }

        if(collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

   /* void increaseSpeed()
    {
        if(score >= 10)
        {
            agroZone.speed++;
            moveTowards.speed++;
        }
    }*/
}
