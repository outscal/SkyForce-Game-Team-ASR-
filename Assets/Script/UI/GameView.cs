using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private UIService uiService;
    public void Start(){
        uiService = GetComponent<UIService>();
    }
    private float damageAmount = 0;
    
    public void HandleBar()
    {
       // uiService.bar.fillAmount = 0.5f;
    }
}
