using Aja.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktester : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        //If the left mouse button is clicked.
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider == null)
            {
                Debug.Log("kosong");
            }

            else
            {
                Debug.Log(hit.collider.name);
                EnemyFire enemyfire = gameObject.GetComponent<EnemyFire>();
                enemyfire.swapAttack(hit.collider.gameObject);
            }
        }
    }
}
