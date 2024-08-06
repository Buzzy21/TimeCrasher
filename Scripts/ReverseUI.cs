using TMPro;
using UnityEngine;
public class ReverseUI : MonoBehaviour
{
    public TextMeshPro count;
    public ReverseTimer reverseTimer;
    void Update()
    {
        count.text = reverseTimer.bombCountdown.ToString("F1");
    }     
}
