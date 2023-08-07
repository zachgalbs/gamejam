using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    float speed = 5f;
    public float jumpHeight = 5f;
    public Rigidbody2D rb;
    public Rigidbody2D ballrb;
    public Vector3 lastPosition;
    AbilityBehavior abilityScript;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballrb = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
        abilityScript = GameObject.Find("Ability").GetComponent<AbilityBehavior>();
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
        if (Input.GetKey(KeyCode.S) && abilityScript.ability == true)
        {
            Debug.Log("s was hit");
            lastPosition = new Vector3(transform.position.x, transform.position.y);
        }
        if (Input.GetKey(KeyCode.F) && abilityScript.ability == true)
        {
            transform.position = lastPosition;

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            ballrb.velocity = new Vector3(ballrb.velocity.x + 10, ballrb.velocity.y, 0);
        }
    }
}
