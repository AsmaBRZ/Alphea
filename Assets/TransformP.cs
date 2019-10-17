using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void changeM(Texture m){
    	GetComponent<Renderer>().material.mainTexture=m;
    }
}
