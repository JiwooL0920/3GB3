// Tutorial - https://www.youtube.com/watch?v=K1xZ-rycYY8&ab_channel=bendux

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 450f;
    private float jumpingPower = 450f;
    private bool faceRight = true;

    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rigidBody.velocity.y > 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, rigidBody.velocity.y * 0.5f);
        }

        ChangeDirection();
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(speed * horizontal, rigidBody.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void ChangeDirection()
    {
        if (faceRight && horizontal < 0f || !faceRight && horizontal > 0f)
        {
            faceRight = !faceRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Enemy")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat1");
        }

        if (other.gameObject.tag == "Enemy2")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat2");
        }

        if (other.gameObject.tag == "Enemy3")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat3");
        }

        if (other.gameObject.tag == "Enemy4")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat4");
        }
        if (other.gameObject.tag == "Enemy7")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat7");
        }

        if (other.gameObject.tag == "Enemy5")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat5");
        }

        if (other.gameObject.tag == "Enemy6")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat6");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat1");
        }

        if (collision.gameObject.tag == "Enemy2")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat2");
        }

        if (collision.gameObject.tag == "Enemy3")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat3");
        }

        if (collision.gameObject.tag == "Enemy4")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat4");
        }

        if (collision.gameObject.tag == "Enemy5")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat5");
        }

        if (collision.gameObject.tag == "Enemy6")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat6");
        }

        if (collision.gameObject.tag == "Enemy7")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("aaaaa");
            SceneManager.LoadScene("Combat7");
        }
    }
}