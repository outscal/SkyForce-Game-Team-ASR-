using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject[] goldenStar;
    private UIService uIService;

    public void Awake()
    {
        ResetStar();
        uIService = GetComponentInParent<UIService>();
        // uIService.gameOverScreen.SetActive(true);

    }
    public void Start()
    {
        if (PlayerPrefs.HasKey("LevelCleared"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("LevelCleared", 0);
        }
        if (PlayerPrefs.HasKey("LevelClearedCount"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("LevelClearedCount", 0);
        }
    }
    public void Update() { }
    public void ResetStar()
    {
        for (int i = 0; i < 3; i++)
        {
            goldenStar[i].SetActive(false);
        }
    }
    public void SetStar(int noOfKills)
    {                           // Set Start acc to kill
        if (noOfKills < 5)
        {

            goldenStar[0].SetActive(true);

        }
        else if (noOfKills >= 5 && noOfKills < 9)
        {

            goldenStar[0].SetActive(true);
            goldenStar[1].SetActive(true);

        }
        else if (noOfKills >= 9)
        {

            goldenStar[0].SetActive(true);
            goldenStar[1].SetActive(true);
            goldenStar[2].SetActive(true);

        }
    }

    public void SetActive_True()
    {
        enabled = true;
    }
    public void SetActive_False()
    {
        enabled = false;
    }
    public void LevelCleared()
    {
        Debug.Log("Button Click");
        int previousBuildIndex = PlayerPrefs.GetInt("LevelCleared");
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        int previousLevelCount = PlayerPrefs.GetInt("LevelClearedCount");
        if (currentBuildIndex > previousBuildIndex)
        {
            PlayerPrefs.SetInt("LevelCleared", SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("LevelClearedCount", previousLevelCount + 1);
            print("level cleared count" + PlayerPrefs.GetInt("LevelClearedCount"));
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnMenuButtonClicked(){
    SceneManager.LoadScene("MainMenu");
    }

}
