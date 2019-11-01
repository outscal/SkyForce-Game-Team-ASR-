using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text levelText;
    public static int levelNo;
    void Start()
    {
        //levelNo = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenScene(int i)
    {
        SceneManager.LoadScene("Level" + i);
    }

    public void PreviousLevel()
    {
        if(levelNo>1)
        {
            levelNo--;
            levelText.text = levelNo.ToString();
        }
    }

    public void NextLevel()
    {
        if (levelNo < 10)
        {
            levelNo++;
            levelText.text = levelNo.ToString();
        }
    }
}
