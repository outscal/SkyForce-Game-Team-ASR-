using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIService : MonoSingletonGeneric<UIService>
{
     public Image healthBar;
     public Text killText;
    private GameView gameView;

    private void Start()
    {

        gameView = healthBar.GetComponentInParent<GameView>();
        killText = GetComponentInChildren<Text>();
        EventServices.KillCounter += callKillCounter;


    }
    public void HealthBarUpdate(float damage)
    {
        Debug.Log("Step 1");
        gameView.HandleBar(damage);
        Debug.Log("Step3");
    }
    private void callKillCounter(){
        gameView.UpdateKillCounter();
    }
    void OnDestroy()
    {
        EventServices.KillCounter -= callKillCounter;
    }
}


