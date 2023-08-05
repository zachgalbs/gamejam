using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    float speed = 5f;
    public float jumpHeight = 5f;
    public Rigidbody2D rb;
    public Rigidbody2D ballrb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballrb = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
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
        if (transform.position.y < -15)
        {
            SceneManager.LoadScene("level 1");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Debug.Log(rb.velocity.x);
            Debug.Log(rb.velocity);
            ballrb.velocity = new Vector3(ballrb.velocity.x + 10, ballrb.velocity.y, 0);
        }
    }
}
