using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class reactionBalles : MonoBehaviour
{
    private void Start()
    {
        score = FindObjectOfType<score>();
    }
    private score score;
    private void OnTriggerEnter2D(Collider2D other){
        switch (other.name)
        {
            case "CaptainAmerica":
                if (gameObject.CompareTag("CaptainAmerica"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);

                    score._score += 100;
                }
                else if (!gameObject.CompareTag("CaptainAmerica"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "Hulk":
                if (gameObject.CompareTag("Hulk"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);

                    score._score += 100;

                }
                else if (!gameObject.CompareTag("Hulk"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "IronMan":
                if (gameObject.CompareTag("IronMan"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);

                    score._score += 100;

                }
                else if (!gameObject.CompareTag("IronMan"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "Thor":
                if (gameObject.CompareTag("Thor"))
                {
                    
                    Destroy(other.gameObject);
                    Destroy(gameObject);

                    score._score += 100;

                }
                else if (!gameObject.CompareTag("Thor"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }
                break;
        }
    }
}