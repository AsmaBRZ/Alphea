using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BigEnemy : MonoBehaviour

{	public float moveSpeed = 0.01f;
    public float turnSpeed = 600f;
    public bool towalk=false;
    public float health=30;
    private int cp=0;
    public GameObject skelton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){   
    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if(health==0){
            Destroy(this);
            transform.gameObject.SetActive(false);
            player.GetComponent<Player>().updateScore(20);
            player.GetComponent<Player>().win();
            
        }
        if(towalk){
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.03f);
        }


    }
    public void walk(){

        towalk= true;
        StartCoroutine(Rotate());
    }
    public void degradeHealth(){
        health--;
        skelton.GetComponent<ChangeMate>().changeMat();

    }
    IEnumerator Rotate(){
        yield return new WaitForSeconds(3f);
        switch(Random.Range(0,2)){
            case 0: transform.Rotate(Vector3.up * - turnSpeed * Time.deltaTime); break;
            default: transform.Rotate(Vector3.up *  turnSpeed * Time.deltaTime); break;

        }
    }
    IEnumerator EnemyDying(){
            
            yield return new WaitForSeconds(3f);
             
    }

}
