using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float mH;
    float speed = 5f;
    public float jumpHeight = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + horizontalInput * speed * Time.deltaTime, transform.position.y, 0);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            // Jump only when the vertical velocity is close to zero (grounded).
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
        }

    }
}
