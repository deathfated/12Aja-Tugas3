using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Aja.Gameplay.Character
{
    public abstract class EnemyBase : MonoBehaviour
    {
        [SerializeField]
        private float getPoint;
        private float speed;
        private bool isleft, isright;
        public void Move()
        {
            if (isleft)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.left);
                Debug.Log("turnleft");
            }

            if (isright)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.right);
                Debug.Log("turnright");
            }
        }

        public void setSpeed(float spd)
        {
            speed = spd;
        }
    }
}