using UnityEngine;

public class PlayerFeatures : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<GameManager>().RestartGame();
        }
        if (rb.position.y < -1)
        {
            //FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GameManager>().RestartGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().Exit();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            PlayerMovment playermv = FindObjectOfType<PlayerMovment>();

            playermv.sidewaysForce = 0;
            playermv.forwardForce = 0;

        }
        if (collision.collider.tag == "Finish")
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            ScoreText.scoreValue++;
            Destroy(other.gameObject);
        }
    }

}
