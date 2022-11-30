using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlNave : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform transform;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime + " seg. " + (1.0f / Time.deltaTime) + "FPS");
        ProcesarInput();   
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "colisionSegura":
                print("Colision Segura ....");
                break;
            case "colisionPeligrosa":
                print("Colision Peligrosa");
                break;
        }
        // if (collision.gameObject.CompareTag("colisionSegura")) {
            
        //     print("Colision Segura ....");

        // }else if (collision.gameObject.CompareTag("colisionPeligrosa")) {

        //     print("Colision Peligrosa");
        // }
    }

    private void ProcesarInput(){
        Propulsion();
        Rotacion();
    }
    private void Propulsion(){
        if (Input.GetKey(KeyCode.Space))//propulsion
        {
            rigidbody.freezeRotation = true;
            //print("Propulsar ...")
            rigidbody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying){
                audioSource.Play();
            }
        }else{

            audioSource.Stop();
        }
        rigidbody.freezeRotation = false;
    }
    private void Rotacion(){
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(-Vector3.forward);
            //print("Rotar Derecha ...");
            var rotarDerecha = transform.rotation;
            rotarDerecha.z -= Time.deltaTime * 0.5f;
            transform.rotation = rotarDerecha;
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            //print("Rotar Izquierda ...");
            //transform.Rotate(Vector3.forward);
            var rotarIzquierda = transform.rotation;
            rotarIzquierda.z += Time.deltaTime * 0.5f;
            transform.rotation = rotarIzquierda;
        }
    }
}
