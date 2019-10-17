using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
     float timeCounter=0f;
     public bool rotate=true;
 Vector3 startPos;
     void Start () {
     	startPos = transform.position;
     }
     
     void Update () {
     	if(rotate){
        timeCounter+=Time.deltaTime;
        float x =startPos.x +Mathf.Cos(timeCounter);
        float y= startPos.y;
        float z= startPos.z +Mathf.Sin(timeCounter);
        transform.position=new Vector3(x,y,z);}
     }
     public void stopRotate(){
     	rotate=false;
     }
}
