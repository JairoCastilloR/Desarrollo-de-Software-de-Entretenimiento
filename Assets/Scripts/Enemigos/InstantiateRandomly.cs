using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{
    public Transform pos;
    public GameObject gameObject;
    private float rangoGeneracion = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        float poxXGeneracion =gameObject.transform.position.x - Random.Range(-rangoGeneracion,rangoGeneracion);
        float poxZGeneracion =gameObject.transform.position.y -Random.Range(-rangoGeneracion,rangoGeneracion);
        Instantiate(gameObject,new Vector3(poxXGeneracion,0,poxZGeneracion),gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
