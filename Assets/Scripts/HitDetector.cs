using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{

    bool hitRecently = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemyController =  other.GetComponent<EnemyController>();
            if (enemyController  != null)
            {
                enemyController.GotHit();
                hitRecently = true;
            }
        }
    }
     private void OnTriggerExit(Collider other)
     {
        hitRecently = false;
     }
    
}

