using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallePrincipale : MonoBehaviour
{
    private score score;
    private void Start()
    {
        score = FindObjectOfType<score>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != name)
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else if (other.name == name)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            score._score += 100;
        }
       
    }
}