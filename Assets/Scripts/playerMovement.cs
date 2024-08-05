using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE: Code taken from: https://www.youtube.com/watch?v=Nxg0vQk05os&list=PLtLToKUhgzwnk4U2eQYridNnObc2gqWo-

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
 
    public float speed = 12f; //float for speed
    public float gravity = -9.81f * 2; //float for gravity. Removes need of a rigidbody
    public float jumpHeight = 3f; //float for jump height
 
    public Transform groundCheck; //checks if on ground
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
 
    Vector3 velocity; // velocity of fall
 
    bool isGrounded;
 
    // Update is called once per frame
    void Update()
    {
        //checking if we hit the ground to reset our falling velocity, otherwise we will fall faster the next time
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
 
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //should probably change these values
        }
 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        //right is the red Axis, foward is the blue axis
        Vector3 move = transform.right * x + transform.forward * z;
 
        controller.Move(move * speed * Time.deltaTime);
 
        //check if the player is on the ground so he can jump
        // if (Input.GetButtonDown("Jump") && isGrounded)
        // {
        //     //the equation for jumping
        //     velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        // }
        //Don't need this if we are not jumping
 
        velocity.y += gravity * Time.deltaTime;
 
        controller.Move(velocity * Time.deltaTime);
    }
}
