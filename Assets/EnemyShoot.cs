using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float rocketSpeed=1;
    public GameObject rocket;
    private IEnumerator coroutine;
    void Start()
    {
    	coroutine=Shoot();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    IEnumerator Shoot() {
        for(;;){
            GetComponent<AudioSource>().Play();
         	GameObject tmpRocket=Instantiate(rocket,transform.position+(transform.forward), transform.rotation) as GameObject;
            Rigidbody tmpRigidBodyRocket=tmpRocket.GetComponent<Rigidbody>();
            tmpRigidBodyRocket.AddForce(tmpRigidBodyRocket.transform.forward *rocketSpeed);
            Destroy(tmpRocket,1f);

            yield return new WaitForSeconds(2f);
        }
            
    }


 public void startShoot(){
 	StartCoroutine(coroutine);
 }
 public void stopShoot(){
    StopCoroutine(coroutine);
 }

}
