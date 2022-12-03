using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorVidas : MonoBehaviour
{
    public static ContadorVidas numVidas;

    public GameObject[] vidas;

    private bool dead;

    private int contVidas;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        contVidas = vidas.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.GetComponent<BarraVida>().vida <= 65)
        {
            Descontar(1);
            target.GetComponent<BarraVida>().vida =
                target.GetComponent<BarraVida>().vidamaxima;
        }
        if (dead == true)
        {
            Debug.Log("MI VERGA");
        }
    }

    public void Descontar(int d)
    {
        Debug.Log (d);
        if (contVidas >= 0)
        {
            contVidas -= d;
            Debug.Log (contVidas);
            Destroy(vidas[contVidas].gameObject);
            if (contVidas == 0)
            {
                dead = true;
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
    private void OnTriggerEnter(Collider other){

        if(other.tag == "caida"){
            Debug.Log("aaaaah mi pichulaa");
            Descontar(1);
        }
    } 
}
