using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFeatures : MonoBehaviour
{
    [SerializeField]
    private PlayerMovment playermv;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            //playermv.enabled = false;
            
            playermv.sidewaysForce = 0;
            playermv.forwardForce = 0;
        }
        if (collision.collider.tag == "Finish")
        {
            SceneManager.LoadScene(1);
            Debug.Log("waidaa meore turi");
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
