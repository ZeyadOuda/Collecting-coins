using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinScript : MonoBehavior;
{
    public gamemanager manager;

    void Start()
    {
     
    }

    void Update()
    {
    
    } 
    Private void OnTriggerEnter(Collider other);
    {
    
    if (other.gameObject.tag == "player")
    {
        manager.coinnumber = manager.coinnumber +1;
        Destroy(gameObject);
    }
    }
 }