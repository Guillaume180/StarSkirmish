using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D myRigBod;

    private int bonusJump;
    public int bonusJumpAmount;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public TimerScript timeState;

    // Start is called before the first frame update
    void Start()
    {
        bonusJump = bonusJumpAmount;
        myRigBod = GetComponent<Rigidbody2D>();
        
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        //for movement
        moveInput = Input.GetAxis("Horizontal");
        myRigBod.velocity = new Vector2(moveInput * Speed, myRigBod.velocity.y);

        //fixes look direction
        if (facingRight ==false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Update()
    {
        if (isGrounded == true)
        {
            bonusJump = bonusJumpAmount;
        }

        if (Input.GetKeyDown(KeyCode.Space) && bonusJump > 0)
        {
            myRigBod.velocity = Vector2.up * jumpForce;
            bonusJump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && bonusJump == 0 && isGrounded == true)
        {

        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tutorial")
        {
            Debug.Log("Enter the Box");
            timeState.state = TimerScript.TimeState.Tutorial;
        }

        if (collision.tag == "FinishLine")
        {
            Debug.Log("You have made it");
            timeState.state = TimerScript.TimeState.Complete;
        }
    }
}
