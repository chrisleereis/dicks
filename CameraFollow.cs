
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour

{
    private float cameraSpeed = 0.5f;
    public float cameraVertical = 0.2f;
    public float cameraHorizontal = 0.1f;
    //private Vector3 getPos;
    //private Rigidbody playerRigidbody;
    //public float jumpSpeed = 50.0f;
    //public bool isJumping;
    //private Collider bottomCollider;
    //public bool facingRight;
    //public bool facingLeft;



    // Start is called before the first frame update
    void Start()
    {
        //isJumping = false;
        //facingRight = false;
        //facingLeft = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //getPos = transform.position;
        // rigidbody jumping
        


        // movement code
        if (Input.GetKey(KeyCode.D))
        {
            //facingRight = true;
            //facingLeft = false;
            transform.Translate(Vector3.right * cameraHorizontal * cameraSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //facingRight = false;
            //facingLeft = true;
            transform.Translate(Vector3.left * cameraHorizontal * cameraSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //if (facingLeft == true)
            //{
                transform.Translate(Vector3.forward * cameraVertical * cameraSpeed);
            //}
            //else
            //{
            //    transform.Translate(Vector3.back * cameraVertical * cameraSpeed);
            //}
        }
        if (Input.GetKey(KeyCode.S))
        {
            //if (facingRight == true)
            //{
                transform.Translate(Vector3.back * cameraVertical * cameraSpeed);
            //}
            //else
            //{
            //    transform.Translate(Vector3.back * cameraVertical * cameraSpeed);
            //}
        }

    }
    //public void OnCollisionEnter(Collision bottomCollider)
    //{
    //    isJumping = false;
    //}
}
