using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMate : MonoBehaviour
{
	public Material m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeMat(){
    	GetComponent<Renderer>().material=m;
    }
}
