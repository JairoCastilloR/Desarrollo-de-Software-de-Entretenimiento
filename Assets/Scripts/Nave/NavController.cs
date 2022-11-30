using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavController : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform transform;

    public float speed = 30f;
    public float jumpSpeed = 20f;
    public float distToGround = 0.5f;
    bool IsGrounded = true;
    private float curSpeed=0.0f;
    private float maxSpeed = 30f;
    public float acceleration=1.0f;
    
    void Start()
    {
        
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();

    }

    void FixedUpdate()
    {
       
        if (Input.GetKey(KeyCode.Space) && IsGrounded)
        {
            Vector3 jumpVelocity = new Vector3(0f,jumpSpeed,0f);
            rigidbody.velocity += jumpVelocity;
            IsGrounded = false;
        }
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * curSpeed;
            curSpeed += acceleration * Time.deltaTime;
            if (curSpeed > maxSpeed){ curSpeed = maxSpeed; }

        }else{

            curSpeed -= acceleration * Time.deltaTime;
            if (curSpeed < 0){ 
                curSpeed = 0; 
            }
            transform.position += Vector3.forward * Time.deltaTime * curSpeed;
        
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("platform")) {
            IsGrounded = true;
        }
    }

   
}
