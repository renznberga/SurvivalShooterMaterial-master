﻿using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{ 
    Transform player;
//    PlayerHealth playerHealth;      // Reference to the player's health.
//    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
//        playerHealth = player.GetComponent<PlayerHealth>();
//        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent> ();
    }

    void Update ()
    {
        // If the enemy and the player have health left...
//        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
//        {
            // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination(player.position);
//        }
        // Otherwise...
//        else
//        {
            // ... disable the nav mesh agent.
//            nav.enabled = false;
//        }
    }
}
