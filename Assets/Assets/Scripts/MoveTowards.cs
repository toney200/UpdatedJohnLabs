using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public GameObject target;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float speedDelta = speed * Time.deltaTime;

        // Position of the target: target.transform.position
        // Position of the NPC: transform.position

        Vector3 newPosition = tusMoveTowards(target.transform.position, speedDelta);

        transform.position = newPosition;
    }

    Vector3 tusMoveTowards(Vector3 pos, float speedDelta)
    {
        
        Vector3 targetPosition = pos;
        Vector3 enemyPosition = transform.position;
       
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










