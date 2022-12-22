using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    public float danio = 5;
    public GameObject target;
    public GameObject enemy;
    public float colision = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   /* void Update()
    {

        if(Vector3.Distance(transform.position,target.transform.position)<2){

            target.GetComponent<BarraVida>().vida-=danio;
            if(enemy.tag=="enemy"){
                Destroy(enemy);
            }
        }
        
    }
*/
    private void OnCollisionEnter(Collision  collision) {
        

        if(collision.gameObject.tag=="Player"){
            //for(i = colision; i <= 30; i++ ){
            m_MyAudioSource.Play();
            target.GetComponent<BarraVida>().vida-=danio;
            //} 
        }

    }
    private void OnCollisionStay(Collision  collision) {
        

        
        if(enemy.tag=="tunelColision" && collision.gameObject.tag=="Player"){
            //for(i = colision; i <= 30; i++ ){
            //m_MyAudioSource.Play();
            target.GetComponent<BarraVida>().vida-=danio;
            //} 
        }
        if(enemy.tag=="dangerZone" && collision.gameObject.tag=="Player"){
            //for(i = colision; i <= 30; i++ ){
            //m_MyAudioSource.Play();
            target.GetComponent<BarraVida>().vida-=danio;
            Debug.Log(collision.gameObject.tag);
            //} 
        }
    }

    private void OnTriggerStay(Collider other) {

        if(other.tag=="spriteDanger"){

            target.GetComponent<BarraVida>().vida-=danio;
            Debug.Log(other);
            //Debug.Log(collision.gameObject.tag);
        }
    }
}
    /*private void OnCollisionExit(Collision  collision) {
        

        if(collision.gameObject.tag=="Player"){
            //for(i = colision; i <= 30; i++ ){
            target.GetComponent<BarraVida>().vida-=colision;
            //} 
        }
    }*/







