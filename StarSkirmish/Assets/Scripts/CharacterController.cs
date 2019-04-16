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

    // Start is called before the first frame update
    void Start()
    {
        bonusJump = bonusJumpAmount;
        myRigBod = GetComponent<Rigidbody2D>(); 
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
}
