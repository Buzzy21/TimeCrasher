using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{   
    public GameObject restartUi;
    public BombTiming bombTiming;
    public GameObject borderExplosion;
    public SoundEffectPlayer soundEffect;
    public GameObject playerExplosion;
    public int score;
    public TextMeshProUGUI scoreCount;
    public GameObject clockExplosion;
    public ScreenShake screenShake;
    public GameObject scoreCountObject;
    public int clockAmount;
    public Image clockLogo;
    public TextMeshProUGUI clockTEXT;

    void OnCollisionEnter2D (Collision2D col) 
    {
        if (col.gameObject.tag == "Spike")
        {
            playerDie();
        }
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "DimensionBorder")
        {
            ChangeTime();
            Destroy(col.gameObject);
            Instantiate(borderExplosion, col.transform.position, Quaternion.identity);
            screenShake.StartCoroutine("Shaking");
            soundEffect.dimensionSwitch();
        }
        if (col.gameObject.tag == "Clock")
        {
            clockAmount += 1;
            soundEffect.playerPickup();
            Destroy(col.gameObject);
        }
    }
    public void ChangeTime()
    {
        if (bombTiming.timed == false) 
        {
            bombTiming.timed = true;
        }
        else if (bombTiming.timed == true) 
        {
            bombTiming.timed = false;
        }
        getScore();
    }
    void Update()
    {
        scoreCount.text = score.ToString();
        if (clockAmount >= 1) 
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) {
                soundEffect.playerUse();
                ChangeTime();
                clockAmount = clockAmount - 1;
                Instantiate(clockExplosion, transform.position, Quaternion.identity);
            }
        }
    }
    public void getScore()
    {
        score += 1;
        PlayerPrefs.SetInt("HighScore", score);;
        highScoreCheck();
    }
    public void highScoreCheck()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
    public void playerDie()
    {
        Destroy(gameObject);
        restartUi.SetActive(true);   
        scoreCountObject.SetActive(false);
        Instantiate(playerExplosion, transform.position, Quaternion.identity);
        screenShake.StartCoroutine("Shaking");
        clockLogo.enabled = false;
        clockTEXT.enabled = false;
        soundEffect.playerBreak();
    }
}