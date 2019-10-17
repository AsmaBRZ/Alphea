using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGar : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeDoor(){
    	transform.position=new Vector3(transform.position[0]-2.8f,transform.position[1],transform.position[2]); 
        Debug.Log(transform.position);
    }
}
