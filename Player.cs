using System.Collection;
using System.Collections.Generic;
using UnityEngine;


public class script: monoBehavior
{
public float JumpSpeed =200;
Animator animator;
bool isGround =false;



void run();

void jump()
{if (isGround== true)

{ 
    rb.AddForce(0,JumpSpeed,0);
    Animator.SetBool("IsJumping",true);
}
}







}