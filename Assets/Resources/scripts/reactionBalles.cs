using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);
                    RaycastHit2D hitBas = Physics2D.Raycast(transform.position, -Vector2.up, 5f);

                    if (hitGauche.collider.CompareTag("CaptainAmerica"))
                    {
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("CaptainAmerica"))
                    {
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("CaptainAmerica"))
                    {
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitBas.collider.CompareTag("CaptainAmerica"))
                    {
                        Destroy(hitBas.collider.gameObject);
                        score._score += 100;
                    }
                    else if (!gameObject.CompareTag("CaptainAmerica"))
                    {
                        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                        rb.constraints = RigidbodyConstraints2D.FreezeAll;
                        BallePrincipale balle = other.AddComponent<BallePrincipale>();
                    }

                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }

                break;
            case "CaptainAmerica10":
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
            case "CaptainAmerica15":
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
            case "CaptainAmerica20":
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
            case "Hulk10":
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
            case "Hulk15":
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
            case "Hulk20":
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
            case "IronMan10":
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
            case "IronMan15":
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
            case "IronMan20":
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
            case "Thor10":
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
            case "Thor15":
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
            case "Thor20":
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