using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class reactionBalles : MonoBehaviour
{

    private void Start()
    {
        score = FindObjectOfType<score>();
    }
    private score score;
    
    private void raycastGauche(Vector2 position, string name, int depth)
    {
        if (depth <= 0) return; 

        RaycastHit2D hitGauche = Physics2D.Raycast(position, Vector2.left, 5f);
        RaycastHit2D hitHaut = Physics2D.Raycast(position, Vector2.up, 5f);

        if (hitGauche.collider.CompareTag(name))
        {
            raycastGauche(hitGauche.collider.transform.position, name, depth - 1); 
            Destroy(hitGauche.collider.gameObject);
            score._score += 100;
        }
        if (hitHaut.collider.CompareTag(name))
        {
            raycastHaut(hitHaut.collider.transform.position, name, depth - 1); 
            Destroy(hitHaut.collider.gameObject);
            score._score += 100;
        }
    }

    private void raycastHaut(Vector2 position, string name, int depth)
{
    if (depth <= 0) return; 
    RaycastHit2D hitGauche = Physics2D.Raycast(position, Vector2.left, 5f);
    RaycastHit2D hitHaut = Physics2D.Raycast(position, Vector2.up, 5f);
    RaycastHit2D hitDroite = Physics2D.Raycast(position, -Vector2.left, 5f);

    if (hitGauche.collider.CompareTag(name))
    {
        raycastGauche(hitGauche.collider.transform.position, name, depth - 1); 
        Destroy(hitGauche.collider.gameObject);
        score._score += 100;
    }
    if (hitHaut.collider.CompareTag(name))
    {
        raycastHaut(hitHaut.collider.transform.position, name, depth - 1); 
        Destroy(hitHaut.collider.gameObject);
        score._score += 100;
    }
    if (hitDroite.collider.CompareTag(name))
    {
        raycastDroite(hitDroite.collider.transform.position, name, depth - 1); 
        Destroy(hitDroite.collider.gameObject);
        score._score += 100;
    }
}

private void raycastDroite(Vector2 position, string name, int depth)
{
    if (depth <= 0) return; 

    RaycastHit2D hitHaut = Physics2D.Raycast(position, Vector2.up, 5f);
    RaycastHit2D hitDroite = Physics2D.Raycast(position, -Vector2.left, 5f);

    if (hitHaut.collider != null && hitHaut.collider.CompareTag(name))
    {
        raycastHaut(hitHaut.collider.transform.position, name, depth - 1); 
        Destroy(hitHaut.collider.gameObject);
        score._score += 100;
    }
    if (hitDroite.collider != null && hitDroite.collider.CompareTag(name))
    {
        raycastDroite(hitDroite.collider.transform.position, name, depth - 1); 
        Destroy(hitDroite.collider.gameObject);
        score._score += 100;
    }
}
    private void OnTriggerEnter2D(Collider2D other){
        switch (other.name)
        {
            case "CaptainAmerica":
                if (gameObject.CompareTag("CaptainAmerica"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitDroite.collider.gameObject);
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
            case "Hulk":
                if (gameObject.CompareTag("Hulk"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Hulk"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Hulk", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Hulk"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Hulk", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Hulk"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Hulk", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    else if (!gameObject.CompareTag("Hulk"))
                    {
                        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                        rb.constraints = RigidbodyConstraints2D.FreezeAll;
                        BallePrincipale balle = other.AddComponent<BallePrincipale>();
                    }

                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
            case "IronMan":
                if (gameObject.CompareTag("IronMan"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("IronMan"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "IronMan", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("IronMan"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "IronMan", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("IronMan"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "IronMan", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    else if (!gameObject.CompareTag("IronMan"))
                    {
                        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                        rb.constraints = RigidbodyConstraints2D.FreezeAll;
                        BallePrincipale balle = other.AddComponent<BallePrincipale>();
                    }

                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
            case "Thor":
                if (gameObject.CompareTag("Thor"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Thor"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Thor", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Thor"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Thor", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Thor"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Thor", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    else if (!gameObject.CompareTag("Thor"))
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("CaptainAmerica"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "CaptainAmerica", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Hulk"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Hulk", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Hulk"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Hulk", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Hulk"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Hulk", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                else if (!gameObject.CompareTag("Hulk"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "Hulk15":
                if (gameObject.CompareTag("Hulk"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Hulk"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Hulk", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Hulk"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Hulk", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Hulk"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Hulk", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
                }
                else if (!gameObject.CompareTag("Hulk"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "Hulk20":
                if (gameObject.CompareTag("Hulk"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Hulk"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Hulk", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Hulk"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Hulk", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Hulk"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Hulk", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
                }
                else if (!gameObject.CompareTag("Hulk"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "IronMan10":
                if (gameObject.CompareTag("IronMan"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("IronMan"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "IronMan", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("IronMan"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "IronMan", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("IronMan"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "IronMan", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("IronMan"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "IronMan", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("IronMan"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "IronMan", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("IronMan"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "IronMan", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("IronMan"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "IronMan", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("IronMan"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "IronMan", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("IronMan"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "IronMan", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
                }
                else if (!gameObject.CompareTag("IronMan"))
                {
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    BallePrincipale balle = other.AddComponent<BallePrincipale>();
                }

                break;
            case "Thor10":
                if (gameObject.CompareTag("Thor"))
                {
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Thor"))
                    {
                        raycastGauche(hitGauche.collider.transform.position,"Thor", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Thor"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Thor", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Thor"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Thor", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Thor"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Thor", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Thor"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Thor", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Thor"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Thor", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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
                    RaycastHit2D hitGauche = Physics2D.Raycast(transform.position, Vector2.left, 5f);
                    RaycastHit2D hitHaut = Physics2D.Raycast(transform.position, Vector2.up, 5f);
                    RaycastHit2D hitDroite = Physics2D.Raycast(transform.position, -Vector2.left, 5f);

                    if (hitGauche.collider.CompareTag("Thor"))
                    {
                        raycastGauche(hitGauche.collider.transform.position, "Thor", 6);
                        Destroy(hitGauche.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitHaut.collider.CompareTag("Thor"))
                    {
                        raycastHaut(hitHaut.collider.transform.position, "Thor", 6);
                        Destroy(hitHaut.collider.gameObject);
                        score._score += 100;
                    }
                    else if (hitDroite.collider.CompareTag("Thor"))
                    {
                        raycastDroite(hitDroite.collider.transform.position, "Thor", 6);
                        Destroy(hitDroite.collider.gameObject);
                        score._score += 100;
                    }
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    
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