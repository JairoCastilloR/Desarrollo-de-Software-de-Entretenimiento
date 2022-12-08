using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shotObj : MonoBehaviour
{
    private float speeD=2f;
    private float timelife=5f;
    [SerializeReference]public GameObject emigo;
    public float follow;
    public GameObject Sprite;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,timelife);
        
    }

    // Update is called once per frame
    void Update()
    {  
        move();
    }

    public void move(){
        if(Vector3.Distance(transform.position,emigo.transform.position)>0.2){
            
            var lookPos= emigo.transform.position-transform.position;
            Quaternion rotation= Quaternion.LookRotation(lookPos);
            transform.rotation= Quaternion.Slerp(transform.rotation,rotation,follow*Time.deltaTime);
            transform.Translate(Vector3.forward*Time.deltaTime*speeD);

        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="piso"){
            GameObject Colition = Instantiate(Sprite,transform.position, Quaternion.identity);

            Colition.gameObject.GetComponent<BarraVida>().vida-=10;
            
            Debug.Log(Colition);

            Destroy(gameObject);

        }if(other.tag=="Player"){
                  Destroy(gameObject);
            }
    }
}
