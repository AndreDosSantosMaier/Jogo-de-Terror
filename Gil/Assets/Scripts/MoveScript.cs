using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public float speed = 6f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded = false; 
    public float crouchSpeed;
    public float crouchYScale;
    public float startYScale;
    Vector3 velocity;
    public Rigidbody rb;

    void Start()
    {
        GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        startYScale = transform.localScale.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerIsGrounded();
        Move();
        Sprint();
    }
    void PlayerIsGrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }
    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 12;
        }
        else
        {
            speed = 6f;
        }
    }
 
}
