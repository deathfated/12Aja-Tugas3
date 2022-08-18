using Aja.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        public float distance;
        public int grid;
        public GameObject row1, row2, row3, row4, row5,
            enemy1, enemy2, enemy3;

        void Start()
        {
            createEnemy();
            EnemyFire enemyfire = gameObject.GetComponent<EnemyFire>();
            enemyfire.setEnemyCount(grid);
            enemyfire.addEnemyList();
        }

        void createEnemy()
        {
            for (int i = 0; i < grid; i++)
            {
                Vector3 pos1 = row1.transform.position;
                pos1 = new Vector3(row1.transform.position.x + (i * distance), row1.transform.position.y + (distance * 0), 0);
                Vector3 pos2 = row2.transform.position;
                pos2 = new Vector3(row1.transform.position.x + (i * distance), row1.transform.position.y + (distance * 1), 0);
                Vector3 pos3 = row3.transform.position;
                pos3 = new Vector3(row1.transform.position.x + (i * distance), row1.transform.position.y + (distance * 2), 0);
                Vector3 pos4 = row4.transform.position;
                pos4 = new Vector3(row1.transform.position.x + (i * distance), row1.transform.position.y + (distance * 3), 0);
                Vector3 pos5 = row5.transform.position;
                pos5 = new Vector3(row1.transform.position.x + (i * distance), row1.transform.position.y + (distance * 4), 0);

                GameObject en1 = (GameObject)Instantiate(enemy1, pos1, Quaternion.identity, row1.transform);
                en1.name = i.ToString();

                GameObject en2 = (GameObject)Instantiate(enemy1, pos2, Quaternion.identity, row2.transform);
                en2.name = (i+11).ToString();

                GameObject en3 = (GameObject)Instantiate(enemy2, pos3, Quaternion.identity, row3.transform);
                en3.name = (i + 22).ToString();

                GameObject en4 = (GameObject)Instantiate(enemy2, pos4, Quaternion.identity, row4.transform);
                en4.name = (i + 33).ToString();

                GameObject en5 = (GameObject)Instantiate(enemy3, pos5, Quaternion.identity, row5.transform);
                en5.name = (i + 44).ToString();
            }
        }
    }
}