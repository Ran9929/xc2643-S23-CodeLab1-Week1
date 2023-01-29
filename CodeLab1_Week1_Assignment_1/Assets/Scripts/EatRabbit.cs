using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatRabbit : MonoBehaviour
{
    
    void OnTriggerEnter (Collider other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        if (player != null)
        {
            player.AddFood();
            Destroy(gameObject);
        }
    }
}
