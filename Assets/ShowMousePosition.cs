using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMousePosition : MonoBehaviour
{	public GameObject mousePointer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       mousePointer.transform.position=snapPosition(getWorldPoint()); 
    }
    // determine the reward position that the user is pointing at with his mouse
    public Vector3 getWorldPoint(){
    	Camera cam=GetComponent<Camera>();
    	Ray ray= cam.ScreenPointToRay(Input.mousePosition);
    	//to obtain information about where the rake is actually hit 
    	RaycastHit hit; 
    	if(Physics.Raycast(ray ,out hit)){
    		return hit.point;
    	}
    	return Vector3.zero;
    }

    public Vector3 snapPosition(Vector3 original){
    	Vector3 snapped;
    	snapped.x=Mathf.Floor(original.x + 0.5f); //take the x value, and this is simply snapping it hole point position
    	snapped.y=Mathf.Floor(original.y + 0.5f); 
    	snapped.z=Mathf.Floor(original.z + 0.5f); 
    	return snapped;
    }
}
