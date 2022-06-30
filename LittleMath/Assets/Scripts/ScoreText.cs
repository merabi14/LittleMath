using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour 
{
    [SerializeField]
    Text scoreText;

    public static int scoreValue;
    
    private void Start()
    {
        scoreText.text = "00";
    }
    private void Update()
    {
        scoreText.text = scoreValue.ToString();
    }
}
