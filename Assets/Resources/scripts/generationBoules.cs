using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class generationBoules : MonoBehaviour
{
    [SerializeField] private GameObject _boulePrefab;
    [SerializeField] private int _hauteur= 5;
    [SerializeField] private int _longueur = 9;
    [SerializeField] private float _tailleBalle = 0.4f;
    [SerializeField] private float _offsetX = 5.0f;
    [SerializeField] private float _offsetY = 5.0f;
    [SerializeField] private Sprite[] _sprites;
    private Transform transform1;
    private List<GameObject> balles = new List<GameObject>();
    private float _offsetDescend = 2.5f;
    [SerializeField] private float _offsetNouvelleRangee = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();
        loadSprites();
        generateBoules();
    }
    
    private void loadSprites()
    {
        _sprites = Resources.LoadAll<Sprite>("balles");
    }
    private void generateBoules()
    {
        for (int i = 0; i < _hauteur; i++)
        {
            for (int j = 0; j < _longueur; j++)
            {
                GameObject boule = Instantiate(_boulePrefab, transform);
                boule.transform.position = new Vector3(transform.position.x + j * _offsetX, transform.position.y - i * _offsetY, 5);
                int spriteIndex = Random.Range(0, _sprites.Length);
                boule.GetComponent<SpriteRenderer>().sprite = _sprites[spriteIndex];
                

                switch (spriteIndex)
                {
                    case 0:
                        boule.tag = "CaptainAmerica"; 
                        break;
                    case 1:
                        boule.tag = "Hulk"; 
                        break;
                    case 2:
                        boule.tag = "IronMan";
                        break;
                    case 3:
                        boule.tag = "Thor";
                        break;
                        
                    default:
                        boule.tag = "Untagged";
                        break;
                }
                CapsuleCollider2D coll = boule.AddComponent<CapsuleCollider2D>();
                coll.isTrigger = true;
                Rigidbody2D rb = boule.AddComponent<Rigidbody2D>();
                reactionBalles reaction = boule.AddComponent<reactionBalles>();
                boule.transform.localScale = new Vector3(_tailleBalle, _tailleBalle, 1.0f);
                balles.Add(boule);
            }
        }
    }

    public void createBalles()
    {
        
    }
    private void descendreBalles()
    {
        
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - _offsetDescend, 5); 
    }

    private void ajouterRangée()
    {
        for (int j = 0; j < _longueur; j++)
        {
            GameObject boule = Instantiate(_boulePrefab, transform);
            boule.transform.position = new Vector3(transform.position.x + j * _offsetX, transform.position.y + _offsetNouvelleRangee, 5);
            int spriteIndex = Random.Range(0, _sprites.Length);
            boule.GetComponent<SpriteRenderer>().sprite = _sprites[Random.Range(0, _sprites.Length)];
            switch (spriteIndex)
            {
                case 0:
                    boule.tag = "CaptainAmerica"; 
                    break;
                case 1:
                    boule.tag = "Hulk"; 
                    break;
                case 2:
                    boule.tag = "SpiderMan";
                    break;
                case 3:
                    boule.tag = "IronMan";
                    break;
                case 4:
                    boule.tag = "Thor";
                    break;
                        
                default:
                    boule.tag = "Untagged";
                    break;
            }
            CapsuleCollider2D coll = boule.AddComponent<CapsuleCollider2D>();
            coll.isTrigger = true;
            Rigidbody2D rb = boule.AddComponent<Rigidbody2D>();
            reactionBalles reaction = boule.AddComponent<reactionBalles>();
            boule.transform.localScale = new Vector3(_tailleBalle, _tailleBalle, 1.0f);
            balles.Add(boule);
        }

        _hauteur++;
        _offsetNouvelleRangee += 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            descendreBalles();
            ajouterRangée();
            descendreBalles();
        }
    }
}
