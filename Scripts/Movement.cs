using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    //Runs when game starts
    //Add physics in FixedUpdate
    public Rigidbody r;
    public float forwardforce=2000;
    public Transform target; // the object to rotate around
	public int Angspeed=200; 
    void Start()
    {
       r=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("up")){
            r.AddForce(0,0,forwardforce*Time.deltaTime);
        }
        if(Input.GetKey("down")){
            r.AddForce(0,0,-forwardforce*Time.deltaTime);
        }
        if(Input.GetKey("left")){
            r.AddForce(-forwardforce*Time.deltaTime,0,0);
            transform.RotateAround(target.transform.position,target.transform.up,-Angspeed * Time.deltaTime);
        }
        if(Input.GetKey("right")){
            r.AddForce(forwardforce*Time.deltaTime,0,0);
            transform.RotateAround(target.transform.position,target.transform.up,Angspeed * Time.deltaTime);
        }
        
    }
}
