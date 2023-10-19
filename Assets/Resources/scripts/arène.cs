using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arène : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limit"))
        {
            attaquegant script = other.GetComponent<attaquegant>();
            Debug.Log("Collision");
            script.directionLancement *= -1;
        }
    }
}