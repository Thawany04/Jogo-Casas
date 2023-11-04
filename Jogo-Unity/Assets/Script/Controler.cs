using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controler : MonoBehaviour
{
    public Text coinText;
    private int coins = 0;

    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
    }

    private void Update()
    {
        win();
    }

    void UpdateCoinText()
    {
        coinText.text = " " + coins;
    }
    public void resetgame()
    {
        SceneManager.LoadScene(1);
    }

    void win()
    {
        if (coins >= 26)
        {
            SceneManager.LoadScene(2);
        }
    }
}
