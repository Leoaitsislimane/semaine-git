using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class arène : MonoBehaviour
{
    private void Awake()
    {
        generationBoules.Instance.OnMove += InstanceOnMove;
    }
    private void OnDestroy()
    {
        generationBoules.Instance.OnMove -= InstanceOnMove;
    }

    private void InstanceOnMove()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 7.0f, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limit"))
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
    }
}