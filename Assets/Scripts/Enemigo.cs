using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float danio = 20;
    public GameObject target;
    public GameObject enemy;
    public float colision = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Vector3.Distance(transform.position,target.transform.position)<2){

            target.GetComponent<BarraVida>().vida-=danio;
            Debug.Log("mi pene");
            Destroy(enemy);

         }
        
    }

    private void OnTriggerStay(Collider other) {
        

        if(other.tag=="Player"){
            //for(i = colision; i <= 30; i++ ){
            target.GetComponent<BarraVida>().vida-=colision;
            //} 
        }
    } 




}
