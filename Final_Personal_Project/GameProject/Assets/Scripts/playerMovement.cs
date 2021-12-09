using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
   // private Player_Base playerBase;
    private Rigidbody2D rigidbody2d;
    public float jumpVelocity = 10f;
    public float moveVelocity = 5f;
    public Transform feet;
    public LayerMask groundLayers;
    // Start is called before the first frame update
    void Start()
    {
  //      playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        MovingPlayer();
        IsGrounded();
    }

    void FixedUpdate()
    {
       
    }

    private void MovingPlayer()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveVelocity;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           
            rigidbody2d.velocity = Vector2.right * moveVelocity;
            print("Object Moving Right");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody2d.velocity = Vector2.left * moveVelocity;
            print("Object Moving Left");
        }
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (IsGrounded() == true)
            {
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
                print("Object Jumping" + IsGrounded());
            }
            else
            {
                print("no Jump" + IsGrounded()) ;
                
            }
        }
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
            print("Object Is Grounded");
        }
        return false;
        print("Object is not Grounded");
    }
}


