using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMr : MonoBehaviour
{
    public GameObject Collectable;

    public float timer = 10;
    public float radius = 1;
    private bool timerIsRunning = false;
    private bool appleSpawned = false;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                
                timer = 0;
                SpawnObject();  
                
               /* if(!appleSpawned)
                {
                    SpawnObject();
                    appleSpawned = true;
                }*/
                ResetTimer();

            }
        }
        
    }

    void SpawnObject()
    {
        Vector3 randomPosition = Random.insideUnitCircle * radius;

        Instantiate(Collectable, randomPosition, Quaternion.identity);
    }

    void ResetTimer()
    {
        timer = 5;
        timerIsRunning = true;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
