using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
    	if(collision.transform.name == "L1Enemy"){
    		collision.gameObject.GetComponent<Enemy>().degradeHealth();
    	}
    	if(collision.transform.name == "Player"){
    		
    		collision.gameObject.GetComponent<Player>().degradeHealth();
    	}
        if(collision.transform.name == "GruntHP"){
            collision.gameObject.GetComponent<BigEnemy>().degradeHealth();
        }

    }

    
}
