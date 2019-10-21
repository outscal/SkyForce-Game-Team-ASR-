using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    private UIService uiService;
    private int kill;
    
    
    public void Start(){
        uiService = GetComponentInParent<UIService>();
        //damageAmount = BulletService.Instance.bulletDamage;
        //EventServices.KillCounter += UpdateKillCounter;
    }
    
    public void HandleBar(float damage)
    {
        Debug.Log("Step 2");
       uiService.healthBar.fillAmount = damage;
    }
    public void UpdateKillCounter(){
        kill=kill+1;
        uiService.killText.text = "Kill = " + kill;
        Debug.Log("kill" + kill);
    }
}
    
