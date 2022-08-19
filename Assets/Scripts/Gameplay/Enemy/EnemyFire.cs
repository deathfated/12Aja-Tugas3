using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Aja.Game;
using UnityEngine.Events;

namespace Aja.Enemy
{
    public class EnemyFire : MonoBehaviour
    {
        public int grid;
        public List<GameObject> enemyList = new List<GameObject>();
        public List<GameObject> readyAttack = new List<GameObject>();

        [SerializeField]
        private float jeda;
        private float defJeda;

        public GameObject bullet;

        public GameObject scoreManager;

        void Start()
        {
            defJeda = jeda;
        }
        void Update()
        {

            if (jeda > 0)
            {
                jeda -= Time.deltaTime;

                return;
            }
            if (readyAttack.Count > 0)
            {
                Fire(Random.Range(0, readyAttack.Count));
            }


            jeda = defJeda;

        }
        public void setEnemyCount(int counted)
        {
            grid = counted;
        }
        public void addEnemyList()
        {

            enemySearch();
            addAttackers();
        }

        void enemySearch()
        {
            for (int i = 0; i < grid * 5; i++)
            {
                GameObject g = GameObject.Find(i.ToString());
                enemyList.Add(g);
            }
        }

        void addAttackers()
        {
            for (int i = 0; i < grid; i++)
            {
                GameObject g = enemyList[i];
                readyAttack.Add(g);
            }
        }

        public void swapAttack(GameObject gameobject)
        {
            int index = readyAttack.IndexOf(gameobject);
            int index1 = enemyList.IndexOf(gameobject);
            int points = 0;
            if(index1 < 22)
            {
                points = 10;
            }
            if (index1 > 21 && index1 < 44)
            {
                points = 20;
            }
            if(index1 > 43)
            {
                points = 30;
            }

            AddScoreScript addscore = scoreManager.GetComponent<AddScoreScript>();
            addscore.incScore(points);

            if (readyAttack.Contains(gameobject))
            {
                if ((index1 + grid) >= (grid * 5))
                {
                    readyAttack.RemoveAt(index);
                    ReSpawn();
                }
                if ((index1 + grid) < (grid * 5))
                {
                    readyAttack[index] = enemyList[index1+grid];
                }
                Destroy(gameobject);
            }
        }

        public void Fire(int x)
        {
            Instantiate(bullet, readyAttack[x].transform.position, Quaternion.identity);
        }

        public void ClearList()
        {
            enemyList.Clear();
            readyAttack.Clear();
        }

        public void ReSpawn()
        {
            if (readyAttack.Count <= 0)
            {
                EnemySpawner enemyspawner = gameObject.GetComponent<EnemySpawner>();
                enemyspawner.Spawn();
            }
        }

        
    }
}