using TMPro;
using UnityEngine;

public class HighScoreText : MonoBehaviour
{
    public TextMeshProUGUI displayedScore;
    void Update()
    {
        displayedScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
