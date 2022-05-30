using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 12f;
    private Camera camera;
    private float Gravity = -9.82f;
    public float JumpSpeed = 5f;
    public float _gravityPlatformer = -12f;
    public float JumpHeight = 1;
    CharacterController controller;
    Vector3 velocity;
    public bool isGrounded = true;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if (isGrounded == false && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded == false)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
        }

        velocity.y += Gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

}
    
