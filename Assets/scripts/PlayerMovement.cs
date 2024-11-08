using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float JumpForce;
    private float MoveInput;
    private bool isGrounded;
    public float checkRadius;
    public Transform groundCheck;
    public LayerMask whatIsGrounded;
    private bool facingRight = true;
    private int extraJumps;
    public int extraJumpsValue;
    private Rigidbody2D rb;
    private bool Lvl5;
    private bool Lvl6;

    public string LevelToLoad;

    public PhysicsMaterial2D MaterialPostac;


    private bool isWalled;
    public LayerMask whatIsWalled;
    public Transform WallCheck;

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (gameObject.transform.position.x >= -15 && gameObject.transform.position.x <= 105)
            {
                gameObject.transform.position = new Vector3(-1, 0, 0);
            }

            if (gameObject.transform.position.x >= 106 && gameObject.transform.position.x <= 205)
            {
                gameObject.transform.position = new Vector3(120, 0, 0);
            }

            if (gameObject.transform.position.x >= 206 && gameObject.transform.position.x <= 380)
            {
                gameObject.transform.position = new Vector3(248, 0, 0);
            }

            if (gameObject.transform.position.x >= 381 && gameObject.transform.position.x <= 500)
            {
                gameObject.transform.position = new Vector3(410, 0, 0);
            }

            if (gameObject.transform.position.x >= 501 && gameObject.transform.position.x <= 680)
            {
                gameObject.transform.position = new Vector3(550, 0, 0);
            }

            if (gameObject.transform.position.x >= 681 && gameObject.transform.position.x <= 800)
            {
                gameObject.transform.position = new Vector3(700, 0, 0);
            }
        }

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(LevelToLoad);
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGrounded);
        isWalled = Physics2D.OverlapCircle(WallCheck.position, checkRadius, whatIsWalled);

        MoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);

        if (facingRight == false && MoveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && MoveInput < 0)
        {
            Flip();
        }


        if (gameObject.transform.position.x >= 525 && gameObject.transform.position.x <= 655)
        {
            Lvl5 = true;
        }
        else
        {
            Lvl5 = false;
        }

        if (gameObject.transform.position.x >= 680 && gameObject.transform.position.x <= 800)
        {
            Lvl6 = true;
        }
        else
        {
            Lvl6 = false;
        }

    }
    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        /*if (WallCheck.transform.position.x >= 13.5 || WallCheck.transform.position.x <= -9.5)
        {
            MaterialPostac.friction = (float)1.0;
        }
        else if (isWalled == false)
        {
            MaterialPostac.friction = (float)0.0;
        }*/


        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * JumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * JumpForce;
            extraJumps--;
        }
        if (Lvl5 == true)
        {

            if (gameObject.transform.position.x >= 525 && gameObject.transform.position.x <= 655 && gameObject.transform.position.y <= -3)
            {
                rb.gravityScale = 0.5f;
                JumpForce = 2;
                extraJumpsValue = 99;
            }
            if (gameObject.transform.position.x >= 525 && gameObject.transform.position.x <= 655)
            {
                extraJumpsValue = 99;
            }
        }
        else
        {
            rb.gravityScale = 8f;
            JumpForce = 23;
            extraJumpsValue = 1;
        }

        if (gameObject.transform.position.x >= 680 && gameObject.transform.position.x <= 800 && Lvl6 == true)
        {
            extraJumpsValue = 200;
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
