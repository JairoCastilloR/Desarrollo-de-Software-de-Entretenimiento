using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMete : MonoBehaviour
{   public Transform target;
    public GameObject cosa;
    public float follow;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
       
    }

    public void move(){
        if(Vector3.Distance(transform.position,target.transform.position)>0.2){
             var lookPos= target.transform.position-transform.position;
            Quaternion rotation= Quaternion.LookRotation(lookPos);
            transform.rotation= Quaternion.Slerp(transform.rotation,rotation,follow*Time.deltaTime);
            transform.Translate(Vector3.forward*Time.deltaTime*speed);

        }
        else{
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) {
            if(other.tag=="Player"){
                cosa.GetComponent<BarraVida>().vida-=10;
            }
    }


}
