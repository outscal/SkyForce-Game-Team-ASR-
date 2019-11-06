using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIService : MonoSingletonGeneric<UIService>
{
    public Image healthBar;
    public Text killText;
    private GameView gameView;
    public GameObject gameOverScreen;
    public GameObject gameOverScreen_Loose;
    private GameOver gameOver;
    private UIState state;


    private void Start()
    {

       // gameView = healthBar.GetComponentInParent<GameView>();
        gameView = GetComponentInChildren<GameView>();
        killText = GetComponentInChildren<Text>();
        EventServices.KillCounter += callKillCounter;
        // gameOver = gameOverScreen.GetComponentInParent<GameOver>();
        gameOver = GetComponentInChildren<GameOver>();
        ChangeState(UIState.Gameview);


    }
    void update()
    {

    }
    public void HealthBarUpdate(float damage)
    {
        Debug.Log("Step 1");
        gameView.HandleBar(damage);
        Debug.Log("Step3");
    }
    public void CheckKills()
    {
        if (gameView.kill < 3)
        {
            Debug.Log("Gameover ui");
            gameOverScreen_Loose.SetActive(true);
        }
        else
        {
            UpdateStars();
        }
    }
    public void UpdateStars()
    {
        ChangeState(UIState.GameOver_Win);
        Debug.Log("dkills = " + gameView.kill);
        gameOverScreen.SetActive(true);
        gameOver.SetStar(gameView.kill);


    }
    private void callKillCounter()
    {

        gameView.UpdateKillCounter();
    }
    public void ChangeState(UIState state)
    {
        //int uIState = (int)state;
        switch (state)
        {
            case UIState.GameOver_Win:
                {

                    Debug.Log("GameOver");
                    gameView.SetActive_False();
                    gameOver.SetActive_True();
                    break;
                }
            case UIState.Gameview:
                {
                    Debug.Log("Enter into switch condition");
                    gameView.SetActive_True();
                    gameOver.SetActive_False();
                    Debug.Log("Gameview");
                    break;
                }

        }
    }

    void OnDestroy()
    {
        EventServices.KillCounter -= callKillCounter;
    }
}


