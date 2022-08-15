using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject enemyParent;
    // Update is called once per frame
    
    void Start()
    {
        enemyParent = GameObject.Find("ENEMY");
    }
    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
        checkBorder();
    }

    public void checkBorder()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.width || screenPosition.y < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            EnemyFire enemyfire = enemyParent.GetComponent<EnemyFire>();
            enemyfire.swapAttack(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
