using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shotObj : MonoBehaviour
{
    public float speeD=500f;
    public float timelife=3000f;
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

    private void OnTriggerStay(Collider other) {
        if(other.tag=="platform"){
            
            /*var x = new Vector3(60,-750,0);
            
            var lookPos= emigo.transform.position-transform.position;
            Debug.Log(emigo.transform.position);
            var lookPos1= emigo.transform.position+x;*/

            //Quaternion rotation= Quaternion.LookRotation(lookPos);
            //, Vector3(-90,-133,0)
            var y = new Vector3(0,1.5f,0);

            GameObject Colition = Instantiate(Sprite,transform.position -y , Quaternion.Euler(-90,-133,0));

            //Colition.gameObject.GetComponent<BarraVida>().vida-=10;
            
            Debug.Log(Colition + "wea");

            Destroy(gameObject);

        }if(other.tag=="Player"){
                  Destroy(gameObject);
            }
    }
}
