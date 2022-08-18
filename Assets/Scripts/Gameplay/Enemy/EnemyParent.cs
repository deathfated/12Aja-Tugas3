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
<<<<<<< HEAD
            if (turnRight)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.right);
                Debug.Log(speed);
=======

            Debug.Log(PlayerPrefs.GetString("playerName"));
            if (turnRight)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.right);
               // Debug.Log(speed);
>>>>>>> Develop-Winner
            }

            if (!turnRight)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.left);
<<<<<<< HEAD
                Debug.Log(speed);
=======
               // Debug.Log(speed);
>>>>>>> Develop-Winner
            }

        }

        public void changeDir()
        {
<<<<<<< HEAD
=======
            transform.Translate(0f, -0.1f, 0f);
>>>>>>> Develop-Winner
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
