using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour

{
    public CharacterController controller;
    public float speed;
    public float gravity = -20f;
    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;
    public float jumpHeight = 3.0f;
    public float crouchSpeed;
    public float crouchWalkSpeed;
    public bool isCrouching = false;
    public bool isCrouched = false;
    private float _timeSinceLastStepPlayed;
    
    


    Vector3 velocity;
    public bool isGrounded = true;
    public AudioClip otherClip;
    private AudioSource playerAudio;
    public AudioClip sprintClip;
    public AudioClip jumpClip;
    

    // Update is called once per frame
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        
        




    }
    void Update()
    {
        Crouch();
        IsCrouchingVoid();
        //checks if player is on ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }
        
        if (Input.GetKey(KeyCode.W))
        {
            
            _timeSinceLastStepPlayed += Time.deltaTime;
            if (_timeSinceLastStepPlayed > 1)
            {
                _timeSinceLastStepPlayed = 0;

                playerAudio.PlayOneShot(otherClip, 1.0f);
                

            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            _timeSinceLastStepPlayed += Time.deltaTime;
            if (_timeSinceLastStepPlayed > 1)
            {
                _timeSinceLastStepPlayed = 0;
                playerAudio.PlayOneShot(otherClip, 1.0f);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            _timeSinceLastStepPlayed += Time.deltaTime;
            if (_timeSinceLastStepPlayed > 1)
            {
                _timeSinceLastStepPlayed = 0;
                playerAudio.PlayOneShot(otherClip, 1.0f);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            _timeSinceLastStepPlayed += Time.deltaTime;
            if (_timeSinceLastStepPlayed > 1)
            {
                _timeSinceLastStepPlayed = 0;
                playerAudio.PlayOneShot(otherClip, 1.0f);
            }
        }
       
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        //if space is pressed, jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isGrounded = false;
            playerAudio.PlayOneShot(jumpClip, 1.0f);
                



        }
        
        if (Input.GetKey("left shift"))
        {
            speed = 15;
            _timeSinceLastStepPlayed += Time.deltaTime;
            if (_timeSinceLastStepPlayed > 1)
            {
                _timeSinceLastStepPlayed = 0;
                playerAudio.PlayOneShot(sprintClip, 1.0f);
            }
        }
       
        if (Input.GetKeyUp("left shift"))
        {
            speed = 5;
        }
        


            //gravity 
            velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    public void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isGrounded)
        {
            isCrouched = !isCrouched;
            isCrouching = true;
        }
    }

    public void IsCrouchingVoid()
    {
        if (!isCrouched)
        {
            if (isCrouching)
            {
                Vector3 temp = transform.localScale;
                temp.y = 1.4f;
                temp.x = 1.4f;
                temp.z = 1.4f;
                transform.localScale = temp;

                if (temp.y <= 0.4f)
                {
                    temp.y = 0.4f;
                    isCrouching = false;
                }
            }
        }

        else if (isCrouched)
        {
            if (isCrouching)
            {
                Vector3 temp = transform.localScale;
                temp.y = 0.4f;
                temp.x = 0.4f;
                temp.z = 0.4f;
                transform.localScale = temp;

                
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
           
        }
        


    }




}
