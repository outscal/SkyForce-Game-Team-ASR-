using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIService : MonoSingletonGeneric<UIService>
{
    public Image healthBar;
    private GameView gameView;

    private void Start()
    {

        gameView = healthBar.GetComponentInParent<GameView>();


    }
    public void HealthBarUpdate(float damage)
    {
        Debug.Log("Step 1");
        gameView.HandleBar(damage);
        Debug.Log("Step3");
    }
}
