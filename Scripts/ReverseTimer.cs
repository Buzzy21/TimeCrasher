using UnityEngine;

public class ReverseTimer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sxfre;
    public GameObject timingText;
    public GameObject blueParticle;
    public float bombCountdown = 0f;
    public CircleCollider2D cc;
    public BombTiming bombTiming;
    public bool explode = true;
    void Start()
    {
        bombCountdown = Random.Range(3, 4);
    }
    void Update ()
    {
        if (bombCountdown > 0) 
        {
            if (bombTiming.timed == true) 
            {
                bombCountdown -= Time.deltaTime;
            }
        }
        if (bombCountdown <= 0) 
        {
            cc.enabled = true;
            Invoke ("DestroyObject", 0.2f);
            if (explode == true) {
                Instantiate(blueParticle, transform.position, Quaternion.identity);
                timingText.SetActive(false);
                explode = false;
                explosion();
            }
        }
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
    public void explosion()
    {
        src.clip = sxfre;
        src.Play();
    }
}
