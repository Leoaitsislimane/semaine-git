using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class reactionBalles : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.name)
        {
            case "CaptainAmerica":
                if (other.CompareTag("CaptainAmerica") && gameObject.CompareTag("CaptainAmerica"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
            case "Hulk":
                if (other.CompareTag("Hulk") && gameObject.CompareTag("Hulk"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
            case "IronMan":
                if (other.CompareTag("IronMan") && gameObject.CompareTag("IronMan"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
            case "Thor":
                if (other.CompareTag("Thor") && gameObject.CompareTag("Thor"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
        }
    }
}


