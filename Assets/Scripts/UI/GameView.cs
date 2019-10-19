using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    private UIService uiService;
    
    public void Start(){
        uiService = GetComponentInParent<UIService>();
        //damageAmount = BulletService.Instance.bulletDamage;
    }
    
    public void HandleBar(float damage)
    {
        Debug.Log("Step 2");
       uiService.healthBar.fillAmount = damage;
    }
}
