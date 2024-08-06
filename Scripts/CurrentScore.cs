using TMPro;
using UnityEngine;

public class CurrentScore : MonoBehaviour
{
    public PlayerCollision playerCollision;
    public TextMeshProUGUI currentScore;
    void Update()
    {
        currentScore.text = "Run Score: " + playerCollision.score.ToString();
    }
}
