using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{   
	public Transform player;
	public Transform enemyLevel;
	public bool LightDetect=false;
    public bool destroyDoor=false;
    public GameObject door;
    public Transform rocketHolder;
	public 	Light light;
    public Material m;
    public Transform c;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if( LightDetect==false){	
        	getClosestPlayer(player);
        }
    }

     public void getClosestPlayer (Transform player){
        Vector3 currentPosition = transform.position;
        Vector3 directionToTarget = player.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if(dSqrToTarget < 3){
                if (Input.GetMouseButtonDown(0)){
                	GetComponent<Renderer>().material=m;
                	light.enabled = true;
                    enemyLevel.gameObject.GetComponent<BigEnemy>().walk();
                    rocketHolder.gameObject.GetComponent<BigEnemyShoot>().startShoot();
                    c.gameObject.GetComponent<FollowPlayer>().setLookPl();
                    door.GetComponent<CloseGar>().closeDoor();
        			LightDetect=true;
                    destroyDoor=true;
        			Destroy(this,1f);
                }
            }
             
    }
}
