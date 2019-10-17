using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2PushButton : MonoBehaviour
{	public Transform door1;
    public Transform door2;
	public Transform player;
	public Transform enemyLevel;
	public bool closeDoor=false;
    public Material m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if( closeDoor==false){	
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
    			door1.gameObject.GetComponent<CloseDoor>().closeDoor(); 
                door2.gameObject.GetComponent<CloseDoor>().closeDoor(); 
    			closeDoor=true;
    			enemyLevel.gameObject.GetComponent<FollowTPlayer>().startFollow();
    			Destroy(this,1f);
            }}
             
    }
}
