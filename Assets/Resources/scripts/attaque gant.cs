using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class attaquegant : MonoBehaviour
{
    [SerializeField] private GameObject ballePrefab; 
    [SerializeField] private GameObject lignePrefab; 
    private GameObject currentLigne; 
    private bool isAiming;
    public Vector2 directionLancement; 
    [SerializeField] public float vitesseLancement = 30f; 
    [SerializeField]private float tailleBalle = 0.5f;
    private Sprite[] sprites;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isAiming = true;
            currentLigne = Instantiate(lignePrefab);
        }

        if (isAiming)
        {
            Vector3 positionSouris = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            directionLancement = (positionSouris - transform.position).normalized;

            if (currentLigne != null)
            {
                currentLigne.transform.position = transform.position;
                currentLigne.transform.right = directionLancement;
            }
        }

        if (Input.GetMouseButtonUp(0) && isAiming)
        {
            isAiming = false;
            Destroy(currentLigne);
            LancerBalle();
            
        }
    }

    private void loadSprites()
    {
        sprites = Resources.LoadAll<Sprite>("balles");
    }

    private void Start()
    {
        loadSprites();
    }

    public void LancerBalle()
    {
        GameObject balle = Instantiate(ballePrefab, transform.position, Quaternion.identity);
        int indiceSprite = UnityEngine.Random.Range(0, sprites.Length);
        balle.GetComponent<SpriteRenderer>().sprite = sprites[indiceSprite];
        switch (indiceSprite)
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
        CircleCollider2D collider = balle.AddComponent<CircleCollider2D>();
        collider.isTrigger = true;
        Rigidbody2D rb = balle.GetComponent<Rigidbody2D>();
        arène arène = balle.AddComponent<arène>();
        rb.velocity = directionLancement * vitesseLancement;
        balle.transform.localScale = new Vector3(tailleBalle, tailleBalle, 1.0f);
    }
}
