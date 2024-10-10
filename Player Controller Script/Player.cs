using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpSpeed;
    private float ySpeed;
    private CharacterController conn;
    public bool isGrounded;
    //Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        conn = GetComponent<CharacterController>();
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        //rb.AddForce(xMove * speed, 0, zMove * speed);
        Vector3 moveDirection = new Vector3 (xMove,0 ,zMove);
        moveDirection.Normalize();
        float magnitude = moveDirection.magnitude;
        magnitude = Mathf.Clamp01(magnitude);
        conn.SimpleMove(moveDirection * magnitude * speed);

        ySpeed += Physics.gravity.y * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            ySpeed = -0.5f;
            isGrounded = false;
        }

        Vector3 vel = moveDirection * magnitude;
        vel.y = ySpeed;
        conn.Move(vel * Time.deltaTime);

        if(conn.isGrounded)
        {
            ySpeed = -0.5f;
            isGrounded = true;
            if(Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpSpeed;
                isGrounded = false;
            }
        }

        if(moveDirection != Vector3.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
        }
    }
}
