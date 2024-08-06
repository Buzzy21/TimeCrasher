using TMPro;
using UnityEngine;
public class TimerUI : MonoBehaviour
{
    public TextMeshPro count;
    public BombTimer bombTimer;
    void Update()
    {
        count.text = bombTimer.bombCountdown.ToString("F1");
    }     
}
