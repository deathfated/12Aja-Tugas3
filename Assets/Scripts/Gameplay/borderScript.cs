using Aja.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderScript : MonoBehaviour
{
    public GameObject enemyParent;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("border");
            EnemyParent enemyparent = enemyParent.GetComponent<EnemyParent>();
            enemyparent.changeDir();
            return;
        }
    }
}
