using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Boot
{
    public class BGM : MonoBehaviour
    {
        public AudioClip bgm;
        AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
}
