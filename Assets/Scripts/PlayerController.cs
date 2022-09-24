using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private float movementSpeed = 0.5f;
    public float verticalInput = 0.2f;
    public float horizontalInput = 0.1f;
    private Vector3 getPos;
    private Rigidbody playerRigidbody;
    public float jumpSpeed = 50.0f;
    public bool isJumping;
    private Collider bottomCollider;
    public bool facingRight;
    public bool facingLeft;

    

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        bottomCollider = GetComponent<BoxCollider>();
        isJumping = false;
        facingRight = false;
        facingLeft = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getPos = transform.position;
        // rigidbody jumping
        if (isJumping == false && Input.GetKey(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isJumping = true;
        }
        
        
        // movement code
        if (Input.GetKey(KeyCode.D))
        {
            facingRight = true;
            facingLeft = false;
            transform.Translate(Vector3.left * horizontalInput * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            facingRight = false;
            facingLeft = true;
            transform.Translate(Vector3.left * horizontalInput * movementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (facingLeft == true)
            {
                transform.Translate(Vector3.forward * verticalInput * movementSpeed);
            }
            else
            {
                transform.Translate(Vector3.back * verticalInput * movementSpeed);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (facingRight == true)
            {
                transform.Translate(Vector3.forward * verticalInput * movementSpeed);
            }
            else
            {
                transform.Translate(Vector3.back * verticalInput * movementSpeed);
            }
        }
        
    }
    public void OnCollisionEnter(Collision bottomCollider)
    {
        isJumping = false;
    }
}
