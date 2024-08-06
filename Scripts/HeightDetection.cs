using UnityEngine;

public class HeightDetection : MonoBehaviour
{   
    public PlayerCollision playerCollision;
    void Update() 
    {   
        if (gameObject.transform.position.y <= -7 || gameObject.transform.position.y >= 7)
        {
            playerCollision.playerDie();
        }
    }
}
