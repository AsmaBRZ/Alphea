using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{	public Transform door;
	public Transform player;
	public Transform enemyLevel;
	public bool destroyDoor=false;
    public Material m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if( destroyDoor==false){	
        	getClosestPlayer(player);
        }

    }	
     public void getClosestPlayer (Transform player){
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        Vector3 directionToTarget = player.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if(dSqrToTarget < 3)
            {
                if (Input.GetMouseButtonDown(0)){
                    GetComponent<Renderer>().material=m;
                    
        			door.position=new Vector3(door.position.x,door.position.y,door.position.z+2f);
                    door.gameObject.GetComponent<Renderer>().material=m;
        			destroyDoor=true;
        			enemyLevel.gameObject.GetComponent<EnemyShoot>().startShoot();
        			Destroy(this,1f);
            }}
             
    }
}
