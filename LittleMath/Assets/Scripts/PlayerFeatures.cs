using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFeatures : MonoBehaviour
{
    [SerializeField]
    private PlayerMovment playermv;
    int activeScene = 0; 
    
    void OnCollisionEnter(Collision collision)
    {
        //Get Current Lvl
        activeScene = SceneManager.GetActiveScene().buildIndex;

        if (collision.collider.tag == "Obstacle")
        {
            //playermv.enabled = false;
            
            playermv.sidewaysForce = 0;
            playermv.forwardForce = 0;
        }
        
        //Next Lvl
        if (collision.collider.tag == "Finish" & activeScene < 3)
        {
            SceneManager.LoadScene(activeScene+1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartTheGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("gamishvi simooon");
        }
    }
    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
