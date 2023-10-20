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

    
    private GameObject _currentBall;
    private int _currentSprite;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isAiming = true;
            CreateBall();
            //currentLigne = Instantiate(lignePrefab);
        }

        if (isAiming)
        {
            Vector3 positionSouris = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            directionLancement = (positionSouris - transform.position).normalized;

            // if (currentLigne != null)
            // {
            //     currentLigne.transform.position = transform.position;
            //     currentLigne.transform.right = directionLancement;
            // }
        }

        if (Input.GetMouseButtonUp(0) && isAiming)
        {
            isAiming = false;
            //Destroy(currentLigne);
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

    
    private void CreateBall()
    {
        _currentBall = Instantiate(ballePrefab, transform.position, Quaternion.identity);
        _currentSprite = UnityEngine.Random.Range(0, sprites.Length);
        _currentBall.GetComponent<SpriteRenderer>().sprite = sprites[_currentSprite];
        switch (_currentSprite)
        {
            case 0:
                _currentBall.name = "CaptainAmerica";
                break;
            case 1:
                _currentBall.name = "Hulk";
                break;
            case 2:
                _currentBall.name = "IronMan";
                break;
            case 3:
                _currentBall.name = "Thor";
                break;
            case 4:
                _currentBall.name = "CaptainAmerica10";
                break;
            case 5:
                _currentBall.name = "CaptainAmerica15";
                break;
            case 6:
                _currentBall.name = "CaptainAmerica20";
                break;
            case 7:
                _currentBall.name = "Hulk10";
                break;
            case 8:
                _currentBall.name = "Hulk15";
                break;
            case 9:
                _currentBall.name = "Hulk20";
                break;
            case 10:
                _currentBall.name = "IronMan10";
                break;
            case 11:
                _currentBall.name = "IronMan15";
                break;
            case 12:
                _currentBall.name = "IronMan20";
                break;
            case 13:
                _currentBall.name = "Thor10";
                break;
            case 14:
                _currentBall.name = "Thor15";
                break;
            case 15:
                _currentBall.name = "Thor20";
                break;
        }
        _currentBall.transform.localScale = new Vector3(tailleBalle, tailleBalle, 1.0f);
    }
    public void LancerBalle()
    {
        CircleCollider2D collider = _currentBall.AddComponent<CircleCollider2D>();
        collider.isTrigger = true;
        Rigidbody2D rb = _currentBall.GetComponent<Rigidbody2D>();
        arène arène = _currentBall.AddComponent<arène>();
        rb.velocity = directionLancement * vitesseLancement;
    }
}
