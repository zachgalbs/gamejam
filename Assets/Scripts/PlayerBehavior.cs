using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    readonly float speed = 5f;
    public float jumpHeight = 5f;
    public Rigidbody2D rb;
    public Rigidbody2D ballrb;
    public Vector3 lastPosition;
    public string sceneName;
    bool abilityActive;
    public int jumps = 1;
    public TextMeshProUGUI text;

    void Start()
    {
        jumps = 1;
        sceneName = SceneManager.GetActiveScene().name;
        rb = GetComponent<Rigidbody2D>();
        if (sceneName == "level 1" || sceneName == "level 2")
        {
            ballrb = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
        }
        abilityActive = PlayerPrefs.GetInt("MyBool") == 1;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + horizontalInput * speed * Time.deltaTime, transform.position.y, 0);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f && jumps > 0)
        {
            // Jump only when the vertical velocity is close to zero (grounded).
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
            jumps--;
            text.text = "Jumps: " + jumps;

        }
        if (transform.position.y < -15)
        {
            SceneManager.LoadScene("level 1");
        }
        if (Input.GetKey(KeyCode.S) && abilityActive)
        {
            Debug.Log("s was hit");
            lastPosition = new Vector3(transform.position.x, transform.position.y);
        }
        if (Input.GetKey(KeyCode.F) && abilityActive)
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
