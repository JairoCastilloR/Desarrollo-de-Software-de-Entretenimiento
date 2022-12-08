using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEne : MonoBehaviour
{    

    public ControlEne control;
     public GameObject target;
     public GameObject target1;
     public GameObject target2;
     public Transform spawnPoint;
    public GameObject objeto;
    private int cot=0;
    public bool shoo=false;
    private int disparo;
    public Collider mycollider;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
           
       
        
    }

    // Update is called once per frame
    void Update()
    {
        TLamiro();
         
        if(mycollider.GetComponent<SphereCollider>().radius>=Vector3.Distance(transform.position,target.transform.position)){
            shoo=true;
        }else{
            shoo=false;
            disparo=0;
        }
         Debug.Log(mycollider.GetComponent<SphereCollider>().radius);
        
      
    }

    public void TLamiro(){
        
     

        var lookPos= target.transform.position-transform.position;
            Quaternion rotation= Quaternion.LookRotation(lookPos);
            transform.rotation= Quaternion.Slerp(transform.rotation,rotation,2*Time.deltaTime);
    }
    IEnumerator FireBullets(){
       
        for(int i=0;i<disparo;i++){
            cot++;
           
                 
          
                
                if(cot==1){
                     target=target2;
                     GameObject theshot= Instantiate(objeto, transform.position,transform.rotation);
                     theshot.GetComponent<shotObj>().emigo=target; 
                     yield return new WaitForSeconds(1f);
                     Debug.Log(cot);
                     cot++;
                    
                }if(cot==2){
                    target=target1;
                    GameObject theshot= Instantiate(objeto, transform.position,transform.rotation);
                    yield return new WaitForSeconds(3f);
                    theshot.GetComponent<shotObj>().emigo=target; 
                    
                    cot=0;
                }
            
            
           
        }
        
    }

   
    private void OnTriggerEnter(Collider other) {
        shoo=true;

        if(other.tag=="Player" && shoo==true){
             disparo=2;
             
             StartCoroutine(FireBullets());
          
            
        }else{
            shoo=false;
        }
         Debug.Log(shoo);
    }

}
