using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarEaten : MonoBehaviour
{
	public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){

    	if(collision.transform.name == "Player"){
    		
    		collision.gameObject.GetComponent<Player>().upgradeHealth();
    		Destroy(this);
    		transform.gameObject.SetActive(false);
    	}


    }
}
