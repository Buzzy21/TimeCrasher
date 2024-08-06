using UnityEngine;
public class BombTimer : MonoBehaviour
{   
    public AudioSource src;
    public GameObject redParticle;
    public float bombCountdown = 0f;
    public CircleCollider2D cc;
    public BombTiming bombTiming;
    public bool explode = true;
    public AudioClip sxfre;
    public GameObject timingText;
    
    void Start()
    {
        bombCountdown = Random.Range(3, 4);
    }
    void Update ()
    {
        if (bombCountdown > 0) 
        {
            if (bombTiming.timed == false) 
            {
                bombCountdown -= Time.deltaTime;
            }
        }
        if (bombCountdown <= 0) 
        {
            cc.enabled = true;    
            if(explode == true) {
                Instantiate(redParticle, transform.position, Quaternion.identity);
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.enabled = false;
                timingText.SetActive(false);
                explosion(); 
            explode = false;
            }
            Invoke ("DestroyObject", 0.2f);
            
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
