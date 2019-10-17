using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvinciblePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision){

    	if(collision.transform.name == "Player"){
    		
    		collision.gameObject.GetComponent<Player>().changeMat10();
    		Destroy(this);
    		transform.gameObject.SetActive(false);
    	}


    }
}
