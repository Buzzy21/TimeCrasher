using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClockDisplay : MonoBehaviour
{
    public TextMeshProUGUI clockNum;
    public Image clockLogo;
    public PlayerCollision playerCol;
    public Color noneColor;
    public Color haveColor;
    void Update()
    {
        if(playerCol.clockAmount <= 0)
        {
            clockLogo.color = noneColor;
            clockNum.text = "";
        }
        if(playerCol.clockAmount >= 1)
        {
            clockLogo.color = haveColor;
            clockNum.text = playerCol.clockAmount.ToString();
        }
    }
}
