using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorVidas : MonoBehaviour
{


    public static ContadorVidas numVidas;
    public GameObject[] vidas;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject vida4;
    public GameObject vida5;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
        //if(vidasImage.gameObject.layer == LayerMask.NameToLayer("vida")){

               //}

    }

    // Update is called once per frame
    void Update()
    {
                if(target.GetComponent<BarraVida>().vida <= 65){
                    vida1.SetActive(false);
                    Debug.Log("weaaa");
                    }


    }

    /*void LeerVidas(){


        foreach (GameObject vidasImage in vidas){
            int i = 0;
            
            if(vidasImage.gameObject.layer == LayerMask.NameToLayer("vidas")){
                if(target.GetComponent<BarraVida>().vida <= 65){
                    vidasImage.GameObject.SetActive(false);
                    }
                i++;
                }
            
            
        }

    }*/
}

