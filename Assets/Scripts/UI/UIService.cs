﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIService : MonoSingletonGeneric<UIService>
{
    public Image healthBar;
    private GameView gameView;

    private void Start()
    {

        gameView = healthBar.GetComponent<GameView>();


    }
    public void HealthBarUpdate(float damage)
    {
        gameView.HandleBar(damage);
    }
}
