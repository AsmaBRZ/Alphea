using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float rocketSpeed=5000;
    public GameObject rocket;
    public float distanceFromPlayer = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
        	Fire();
        }
    }
    void Fire(){
    	//The player shoots
    	
    	
            
            	GameObject tmpRocket=Instantiate(rocket,transform.position+(transform.forward * distanceFromPlayer), transform.rotation) as GameObject;
            	Rigidbody tmpRigidBodyRocket=tmpRocket.GetComponent<Rigidbody>();
            	tmpRigidBodyRocket.AddForce(tmpRigidBodyRocket.transform.forward *rocketSpeed);
            	GetComponent<AudioSource>().Play();
            	Destroy(tmpRocket,1f);
            
    }
}
