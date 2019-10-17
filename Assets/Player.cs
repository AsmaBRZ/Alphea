using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{   public float moveSpeed = 0.1f;
	public float turnSpeed = 1000f;
	public float health=10;
    public Transform camera;
    public RuntimeAnimatorController animator;
    public Transform rocketHolder;
    public Texture m1;
    public Texture m2;
    public Texture m3;
    public bool inv=false;
    public Transform childP;
    public Text scoreValue;
    public Text healthValue;
    public int score=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {	
    	if(health==0){
             StartCoroutine(PlayerDyingHealth());        	
        }
    	if(transform.position[1]<0){
    		//out of terrain ---> Die
    		StartCoroutine(PlayerDying());
        	
    	}if(transform.position[1]>1){
    		transform.position=new Vector3(transform.position[0],0.16f,transform.position[2]);        	
    	}

        if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            GetComponent<Animator>().enabled = true;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            GetComponent<Animator>().enabled = true;
        }
         if(Input.GetKeyUp(KeyCode.UpArrow)){
            GetComponent<Animator>().enabled = false;
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)){
            GetComponent<Animator>().enabled = false;
        }
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(Vector3.up * - turnSpeed * Time.deltaTime);
            camera.Rotate(Vector3.up * - turnSpeed * Time.deltaTime);
        }
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(Vector3.up *  turnSpeed * Time.deltaTime);
            camera.Rotate(Vector3.up *  turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Escape)){
            LoadContinueMenu();
        }

    }

    IEnumerator PlayerDying(){
    	yield return new WaitForSeconds(2f);
    	Destroy(this,1f);
    	transform.gameObject.SetActive(false);
        SceneManager.LoadScene(2);
    }
    private int currentScenecIndex;
     public void LoadContinueMenu(){
       currentScenecIndex=SceneManager.GetActiveScene().buildIndex;
       PlayerPrefs.SetInt("SavedScene",currentScenecIndex);
       SceneManager.LoadScene(0);
    }
    public void degradeHealth(){
        if(! inv){
    	   health--;
           SetHealthValue();
        }
    }
    IEnumerator PlayerDyingHealth(){
        GetComponent<Animator>().runtimeAnimatorController = animator;
        GetComponent<Animator>().enabled = true;
        rocketHolder.gameObject.GetComponent<BigEnemyShoot>().stopShoot();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }
    public void upgradeHealth(){
        health++;
        SetHealthValue();
        StartCoroutine(ChangingMat());
    }
    IEnumerator ChangingMat(){
        childP.gameObject.GetComponent<TransformP>().changeM(m2);
        yield return new WaitForSeconds(2f);
        childP.gameObject.GetComponent<TransformP>().changeM(m1);
    }
    public void changeMat10(){
        StartCoroutine(invinc());
    }
    IEnumerator invinc(){
        childP.gameObject.GetComponent<TransformP>().changeM(m3);
        inv=true;
        yield return new WaitForSeconds(10f);
        childP.gameObject.GetComponent<TransformP>().changeM(m1);
        inv=false;
    }

    public void SetHealthValue()
    {
        healthValue.text="";
        healthValue.text = health.ToString();

    }
    public void SetScoreValue()
    {
        scoreValue.text = score.ToString();

    }
    public void updateScore(int v){
        score+=v;
        SetScoreValue();
    }
    public void win(){
        SceneManager.LoadScene(3);
    }
}
