using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public float newPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeDoor(){
    	transform.position=new Vector3(transform.position[0]+newPos,transform.position[1],transform.position[2]); 
    }
}
