using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
	public float health=2f;
    public GameObject skelton;
    public GameObject player;
    private bool scoreToPlayer=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(health==0){
        	GameObject gun=transform.Find("RocketHolder").gameObject;
        	gun.GetComponent<EnemyShoot>().stopShoot();
        	//Destroy(this);
            GetComponent<EnemyMove>().stopRotate();
        	//transform.gameObject.SetActive(false);
            GetComponent<Animation>().Play("Death");
            if(! scoreToPlayer){
                player.GetComponent<Player>().updateScore(5);
                scoreToPlayer=true;
            }
            
        }
    }
    public float getHealth(){
    	return health;
    }
    public void degradeHealth(){
    	health--;
        skelton.GetComponent<ChangeMate>().changeMat();
    }
}
