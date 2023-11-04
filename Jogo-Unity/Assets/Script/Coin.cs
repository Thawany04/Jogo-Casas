using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource Source;

    private void Start()
    {
        Source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Controler coinCounter = GameObject.FindObjectOfType<Controler>();
        if (coinCounter != null)
        {
            Source.Play();
            coinCounter.AddCoin();
            Destroy(gameObject, 0.4f);
        }
    }
}
