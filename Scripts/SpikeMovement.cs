using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float spikespeed = 0f;
    void FixedUpdate ()
    {
        rb.velocity = new Vector2 (-spikespeed, 0f);
    }
}
