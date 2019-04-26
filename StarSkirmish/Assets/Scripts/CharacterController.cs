using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public float Speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D myRigBod;

    private int bonusJump;
    public int bonusJumpAmount;

    public bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public GameObject gameOverScreen;
    public TimerScript timeState;
    public ScoreScript scorePoints;

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
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        { 
            Flip();
        }
      

        if (moveInput != 0)
        {
            GetComponent<Animator>().SetBool("Walking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Walking", false);
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
            GetComponent<Animator>().SetTrigger("Jump");
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

        //transform.Rotate(0f, 180f, 0f);

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
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

        if (collision.tag == "ScoreBlocks")
        {
            scorePoints.scoreBlocks += 25;
        }

        if (collision.tag == "OutOfGameZone")
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }

        if (collision.tag == "Enemy")
        {
            Debug.Log("Death");
            /*Destroy(gameObject);*/
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);

        }
    }
}
