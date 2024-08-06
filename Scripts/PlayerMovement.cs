using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float heightspd = 0f;
    void FixedUpdate()
    {
        rb.velocity = new Vector2 (0f, -heightspd);
        if (Input.GetKey(KeyCode.Space)) 
        {
            RemoveConstraint();
            rb.velocity = new Vector2 (0, heightspd);
        }
        Invoke("RemoveConstraint", 2);
    }
    public void RemoveConstraint()
    {
        rb.constraints = RigidbodyConstraints2D.None;
    }
}
