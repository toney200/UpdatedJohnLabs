using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyAgroZone : MonoBehaviour
{
    
    public GameObject Target;
    public GameObject Enemy;
    public float speed = 1;
    private bool targetDetected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetDetected)
        {
            float speedDelta = speed * Time.deltaTime;

            // Position of the target: target.transform.position
            // Position of the NPC: transform.position

            Vector3 newPosition = tusMoveTowards(Target.transform.position, speedDelta);

            Enemy.transform.position = newPosition;
        }

       
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals(Target.name))
        {
            targetDetected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals(Target.name))
        {
            targetDetected = false;
        }
    }

    Vector3 tusMoveTowards(Vector3 pos, float speedDelta)
    {

        Vector3 targetPosition = pos;
        Vector3 enemyPosition = Enemy.transform.position;

        Vector3 rangeToClose = targetPosition - enemyPosition;
        Vector3 normalizedRangeToClose = rangeToClose.normalized;

        //Debug.DrawRay(enemyPosition, rangeToClose, Color.green);

        rangeToClose.Normalize();
        // Debug.DrawRay(enemyPosition, normalizedRangeToClose, Color.red);

        // float distance = rangeToClose.magnitude;

        Vector3 newPosition = new Vector3();

        Vector3 delta = normalizedRangeToClose * speedDelta;
        newPosition = enemyPosition + delta;
        return newPosition;
    }
}
