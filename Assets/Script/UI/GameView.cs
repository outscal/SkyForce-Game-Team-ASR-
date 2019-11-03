using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    private UIService uiService;
    [HideInInspector]
    public int kill;


    public void Start()
    {
        uiService = GetComponentInParent<UIService>();
        
    }

    public void HandleBar(float damage)
    {
        Debug.Log("Step 2");
        uiService.healthBar.fillAmount = damage;
       
    }
    public void UpdateKillCounter()
    {
        Debug.Log("enter kill counter");
        kill = kill + 1;
        uiService.killText.text = "Kill = " + kill;
        Debug.Log("kill" + kill);
    }
    public void SetActive_True()
    {
        Debug.Log("Active");
        enabled = true;
    }
    public void SetActive_False()
    {
        enabled = false;
    }

}

