using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class NavController1 : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform transform;
    [SerializeField]
    public GameObject dustCloud;
    public GameObject dustCloudBlack;
    

    public float speed = 30f;
    public float jumpSpeed = 20f;
    public float distToGround = 0.5f;
    bool IsGrounded = true;
    private float curSpeed=0.0f;
    private float maxSpeed = 30f;
    public float acceleration=1.0f;
    public float gravity = -9.8f;
    private GameObject cloneDust;

    AudioSource audioSource;

    void Start()
    {
        
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    
    }

    void Update()
    {
       
        if (Input.GetKey(KeyCode.Space) && IsGrounded)
        {
            jumpSpeed += gravity * Time.deltaTime;
            Vector3 jumpVelocity = new Vector3(0f,jumpSpeed,0f);
            rigidbody.velocity += jumpVelocity;
            gameObject.transform.Rotate(-8.5f, 0.0f, 0.0f);
            IsGrounded = false;
            audioSource.Play();
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
            //animation
            Instantiate (dustCloud, transform.position,dustCloud.transform.rotation);
            //gameObject.transform.Rotate(0.0f, 0.0f, 0.0f);
            //audioSource.Stop();
            //IsGrounded = true;
            rotateNav();
        }
        if (collision.gameObject.CompareTag("tunelColision")) {
            
            cloneDust = Instantiate (dustCloudBlack, transform.position,dustCloudBlack.transform.rotation);
        }
    }
   
    private void OnCollisionExit(Collision collision){
        if (collision.gameObject.CompareTag("tunelColision")) {
            Destroy (cloneDust, 1f);
        }
    }
    private async void rotateNav(){
        gameObject.transform.Rotate(0.0f, 0.0f, 0.0f);
        audioSource.Stop();
        await Task.Delay(500);
        IsGrounded = true;
    } 
   
}
