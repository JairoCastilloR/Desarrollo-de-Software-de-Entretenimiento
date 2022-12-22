using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{

    public GameObject gameObject;
    int x,z,enemycount;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(spawnEnemy());
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator spawnEnemy(){
        while(enemycount < 10){
            x = Random.Range(-100,100);
            z = Random.Range(100,100);
            Instantiate(gameObject,new Vector3(transform.position.x + x,32,transform.position.z + z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemycount +=1;
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(spawnEnemy());
    }

}
