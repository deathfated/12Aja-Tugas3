using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Boot
{
    public class SplashScreenManager : MonoBehaviour
    {
        [SerializeField] private GameObject ScoreScreen;

        private void Update()
        {
            ScoreScreen.SetActive(true);
        }
    }
}