﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (other.tag == "Boundary") {
            return;
        }*/
        
        if (other.tag == "Player") {
            print("Enemy Damaged the Player");
            
        }
        

        Destroy(gameObject);
    }

}
