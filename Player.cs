using System.Collection;
using System.Collections.Generic;
using UnityEngine;


public class script: monoBehavior
{
public float JumpSpeed =200;
Animator animator;
bool isGround = false;
public float speed =10f;
rigidbody rb;



void run()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input. GetAxis("Vertical");

        if (hor !=0){animator.setbool("IsRunning",true);}
        else if (ver !=0){animator.SetBool(IsRunning,false);}
        else{ animator.SetBool("IsRunning",false);}

        transform.translate(hor* speed* Time.deltaTime,0,ver *Speed *Time.deltaTime);
    }

void jump()
{if (isGround== true)

{ 
    rb.AddForce(0,JumpSpeed,0);
    Animator.SetBool("IsJumping",true);
}










void start ()
    {
        rb= GetComponent<Rigidbody>();
        animator=GetComponent<animator>();
    }

void Update()
    {
        run();
        if(Input.GetKeyDown(KeyCode.Space)) {jump();}}

    
private void OnCollisionEnter(Collision  collision)
    {
        if (collision.gameObject.tag=="ground"){isGround=true;
     
              animator.SetBool("IsJumping",false);
    }
}
private void OnCollisionExit(Collision collision)
    {
     if (collision.gameObject.tag=="ground"){isGround=false;}   

    }



}