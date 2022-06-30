using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    [SerializeField]
    GameObject completeLevelUI;
    
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("morcha gatavda");
        }
    }
    
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("NextLvl", 2f);
    }
    
    public void NextLvl()
    {
        int temp = SceneManager.GetActiveScene().buildIndex;
        if (temp < 5)
        {
            completeLevelUI.SetActive(false);
            SceneManager.LoadScene(temp + 1);
            ScoreText.scoreValue = 0;
        }
    }
    public void RestartGame()
    {
        ScoreText.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
