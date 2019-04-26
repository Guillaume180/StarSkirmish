// Patrol.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    public float topSpeed;
    Rigidbody2D myRigid;

    private NavMeshAgent agent;

    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        PatrolUpdate();
    }

    void PatrolUpdate()
    {
        //check if we are close enough to the destination
        if((transform.position - points[destPoint].position).magnitude < 0.25f)
        {

            //if we are check to see if we are at the last destination
            if (destPoint + 1 >= points.Length)
            {
                //go back to the first destination
                destPoint = 0;
            }
            else
            {
                //go to the next destination if not at the last destination.
                destPoint++;
            }
        }

        if (myRigid.velocity.magnitude > topSpeed)
        {
           //stop if we are at max speed
            return;
        }

        if ((transform.position - points[destPoint].position).normalized.x > 0)
        {   //on the left 
            //add force to move left
            myRigid.AddForce(Vector2.left * 350 * Time.deltaTime);            
        }
        else
        {
            //on the right
            //add force to move right
            myRigid.AddForce(Vector2.right * 350 * Time.deltaTime);
        } 

        

    }
   
}