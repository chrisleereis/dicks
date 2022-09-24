using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool facingRight;
    public bool facingLeft;
    public float flipSpeed = 0.5f;
    Quaternion leftFace = Quaternion.Euler(0, 0, 0);
    Quaternion rightFace = Quaternion.Euler(0, 180, 0);
    public Quaternion currentFace;
    

    void Start()
    {
            // Application.targetFrameRate = 30;
        facingRight = false;
        facingLeft = false;
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Slerp(this.transform.rotation, currentFace, flipSpeed);
        if (facingRight == false && Input.GetKey(KeyCode.D))
        {
            facingRight = true;
            facingLeft = false;

            currentFace = rightFace;

        }
        if (facingLeft == false && Input.GetKey(KeyCode.A))
        {
            facingRight = false;
            facingLeft = true;

            currentFace = leftFace;


        }
    }
}
