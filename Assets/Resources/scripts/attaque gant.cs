using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class attaquegant : MonoBehaviour
{
    [SerializeField] private GameObject ballePrefab; 
    [SerializeField] private GameObject lignePrefab; 
    private GameObject currentLigne; 
    private bool isAiming; 
    private Vector2 shootDirection; 
    [SerializeField]private float shootVitesse = 30f; 
    [SerializeField]private float _tailleBalle = 0.4f;
    private Sprite[] _sprites;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isAiming = true;
            currentLigne = Instantiate(lignePrefab);
        }

        if (isAiming)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            shootDirection = (mousePosition - transform.position).normalized;

            if (currentLigne != null)
            {
                currentLigne.transform.position = transform.position;
                currentLigne.transform.right = shootDirection;
            }
        }

        if (Input.GetMouseButtonUp(0) && isAiming)
        {
            isAiming = false;
            Destroy(currentLigne);
            ShootBubble();
        }
    }

    private void loadSprites()
    {
        _sprites = Resources.LoadAll<Sprite>("balles");
    }

    private void Start()
    {
        loadSprites();
    }

    void ShootBubble()
    {
        GameObject balle = Instantiate(ballePrefab, transform.position, Quaternion.identity);
        balle.transform.localScale = new Vector3(_tailleBalle, _tailleBalle, 1.0f);
        int spriteIndex = Random.Range(0, _sprites.Length);
        balle.GetComponent<SpriteRenderer>().sprite = _sprites[Random.Range(0, _sprites.Length)];
        switch (spriteIndex)
        {
            case 0:
                balle.name = "CaptainAmerica";
                break;
            case 1:
                balle.name = "Hulk";
                
                break;
            case 2:
                balle.name = "IronMan";
                break;
            case 3:
                balle.name = "Thor";
                break;
        }
        CapsuleCollider2D coll = balle.AddComponent<CapsuleCollider2D>();
        coll.isTrigger = true;
        Rigidbody2D rb = balle.AddComponent<Rigidbody2D>();
        rb.velocity = shootDirection * shootVitesse;
        balle.transform.localScale = new Vector3(_tailleBalle, _tailleBalle, 1.0f);
        
    }

   
}
