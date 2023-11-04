using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLive : MonoBehaviour
{
    public Player player;
    public Slider healthBar;

    void Update()
    {
        healthBar.value = player.life;
    }
}
