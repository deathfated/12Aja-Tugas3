using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Enemy
{
    public class EnemyParent : MonoBehaviour
    {
        public float speed;
        private bool turnRight;
        // Start is called before the first frame update
        void Start()
        {
            turnRight = true;
        }

        // Update is called once per frame
        void Update()
        {

            Debug.Log(PlayerPrefs.GetString("playerName"));
            if (turnRight)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.right);
               // Debug.Log(speed);
            }

            if (!turnRight)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.left);
               // Debug.Log(speed);
            }

        }

        public void changeDir()
        {
            transform.Translate(0f, -0.1f, 0f);
            if (turnRight)
            {
                turnRight = false;
            }
            else
            {
                turnRight = true;
            }

        }
    }
}
