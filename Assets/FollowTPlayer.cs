using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTPlayer : MonoBehaviour
{
    public GameObject player;
    //private Animation anim;
    private bool follow=false;
    void Start()
    {
        //anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
         if(follow==true){
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.02f);
         }
    }
    public void startFollow(){
        follow=true;
        //anim.Play("Walk");
    }
}
