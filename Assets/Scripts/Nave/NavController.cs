using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NavController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    public bool IsGrounded = true;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody rigidbody;

    void Start(){
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update(){
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKey(KeyCode.Space) && IsGrounded)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            IsGrounded = false;
        }
    }
private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("platform")) {
        //animation
        IsGrounded = true;
    }
}
}


   

