using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public int grid, enemyCount;
    public List<GameObject> enemyList = new List<GameObject>();
    public List<GameObject> readyAttack = new List<GameObject>();

    [SerializeField]
    private float jeda;
    private float defJeda;

    public GameObject bullet;

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
        enemyCount = grid;
    }
    public void addEnemyList()
    {
        enemyCount = grid;
        int index = 1;

        for (int i = 0; i < 5; i++)
        {
            enemySearch(index);
            if (enemyCount == 0)
            {
                index += 1;
                enemyCount = grid;
            }
        }

        addAttackers();

        
    }

    void enemySearch(int index)
    {
        for (int i = 0; i < grid; i++)
        {

            enemyCount -= 1;
            GameObject g = GameObject.Find(index.ToString() + (i + 1));
            enemyList.Add(g);
        }

        int lenght = enemyList.Count;

        for(int x = 0; x < lenght; x++)
        {
            enemyList[x].name = x.ToString();
        }
    }

    void addAttackers()
    {
        for (int i = 0; i < grid; i++)
        {
            GameObject g = GameObject.Find(i.ToString());
            readyAttack.Add(g);
        }
    }

    public void swapAttack(GameObject gameobject)
    {
        int index = readyAttack.IndexOf(gameobject);

        int index1 = enemyList.IndexOf(gameobject);

        int idx = int.Parse(gameobject.name);

        

        if (readyAttack.Contains(gameobject))
        {

            enemyList.RemoveAt(index);
            if (GameObject.Find((idx + grid).ToString()) == null)
            {
                readyAttack.RemoveAt(index);
            }

            if (GameObject.Find((idx + grid).ToString()) != null)
            {
                readyAttack[index] = GameObject.Find((idx + grid).ToString());
                //  readyAttack.RemoveAt(index);

            }
            Destroy(gameobject);
        }
    }

    public void Fire(int x)
    {
        Instantiate(bullet, readyAttack[x].transform.position, Quaternion.identity);
    }
}
