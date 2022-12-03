using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvl : MonoBehaviour
{
    public GameObject crystal;
    private FadeScript fade;
    private void Awake(){
        fade = FindObjectOfType<FadeScript>();
    }
    
    private void OnTriggerEnter(Collider other) {
        

        if(other.tag=="Player"){
            Debug.Log("Ingresando nuevo nivel");
            fade.HacerFade();
            fade.PasarNivel();
            Destroy(crystal);
        }
    }
}
