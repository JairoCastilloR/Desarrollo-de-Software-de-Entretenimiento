using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidasContador : MonoBehaviour
{
    private GameObject[] vidas;
    public GameObject prefab;
    public GameObject padreObject;
    public GameObject target;
    public int numVidas;
    private bool dead;
    //sobrecarga paremetrica csm..... ~~~
    void Start()
    {
        vidas = new GameObject[numVidas];
        for (var i = 0; i < numVidas; i++)
        {
            GameObject a = Instantiate(prefab,padreObject.transform);
            a.transform.position = new Vector3(a.transform.position.x + (50*i), a.transform.position.y , 0);
            vidas[i] = a;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(numVidas);
        if (target.GetComponent<BarraVida>().vida <= 65){
            Descontar();
        }
    }

    public void Descontar()
    {
        if (numVidas >= 0)
        {
            numVidas--;
            Destroy(vidas[numVidas].gameObject);
            SceneManager.LoadScene("Scene1");
        }
    }

    private void OnTriggerEnter(Collider other){

        if(other.tag == "caida"){
            Descontar();
        }
    } 
    
}
