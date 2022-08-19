using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Enemy
{
    public class EnemyParent : MonoBehaviour
    {
        public float speed;
        private bool turnRight, isMoving;
        // Start is called before the first frame update
        void Start()
        {
            turnRight = true;
            isMoving = true;
        }

        // Update is called once per frame
        void Update()
        {

          //  Debug.Log(PlayerPrefs.GetString("playerName"));
            if (turnRight && isMoving)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.right);
               // Debug.Log(speed);
            }

            if (!turnRight && isMoving)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.left);
               // Debug.Log(speed);
            }

        }

        public void changeDir()
        {
            
            if (turnRight)
            {
                isMoving = false;
                turnRight = false;
                transform.Translate(-0.3f, -0.2f, 0f);
                isMoving = true;
            }
            else
            {
                isMoving = false;
                turnRight = true;
                transform.Translate(0.3f, -0.2f, 0f);
                isMoving = true;
            }

        }

        public void startDir()
        {
            turnRight = true;
            isMoving = true;
        }
    }
}
