using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float danio = 20;
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Vector3.Distance(transform.position,target.transform.position)<2){

            target.GetComponent<BarraVida>().vida-=danio;

         }
        
    }




}
