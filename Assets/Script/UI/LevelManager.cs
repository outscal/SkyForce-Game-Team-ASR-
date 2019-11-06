using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{

    void Start()
    {
        DisableAll();
        if (!PlayerPrefs.HasKey("LevelClearedCount"))
            PlayerPrefs.SetInt("LevelClearedCount", 0);
        int clearedLevel = PlayerPrefs.GetInt("LevelClearedCount");
        for (int i = 0; i < clearedLevel + 1; ++i)
        {
            transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        }

    }
    public void DisableAll()
    {
        int levelsButtonCount = transform.childCount;
        for (int i = 0; i < levelsButtonCount; i++)
        {
            transform.GetChild(i).GetComponent<Button>().interactable = false;
        }
    }
    public void PlayLevel(int level = 0)
    {
        SceneManager.LoadScene(level);
    }
    public void ResetLevels(){
        int levelsButtonCount = transform.childCount;
        for (int i = 1; i < levelsButtonCount; i++)
        {
            transform.GetChild(i).GetComponent<Button>().interactable = false;
        }
        PlayerPrefs.DeleteAll();
    }
}
