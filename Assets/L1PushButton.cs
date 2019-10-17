using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1PushButton : MonoBehaviour
{	public Transform door1;
    public Transform door2;
	public Transform player;
	public Transform enemyLevel2;
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
        Vector3 currentPosition = transform.position;
        Vector3 directionToTarget = player.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if(dSqrToTarget < 3)
            {if (Input.GetMouseButtonDown(0)){
                GetComponent<Renderer>().material=m;
                door1.position=new Vector3(door1.position.x-1f,door1.position.y,door1.position.z);
                door1.gameObject.GetComponent<Renderer>().material=m;
                door2.position=new Vector3(door2.position.x-2f,door2.position.y,door2.position.z);
                door2.gameObject.GetComponent<Renderer>().material=m;

    			destroyDoor=true;
    			enemyLevel2.gameObject.GetComponent<FollowTPlayer>().startFollow();
            }}
             
    }
}
