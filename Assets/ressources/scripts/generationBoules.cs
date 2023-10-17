using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generationBoules : MonoBehaviour
{


    [SerializeField] private GameObject _boulePrefab;
    [SerializeField] private int _longueur= 6;
    [SerializeField] private int _hauteur = 7;
    [SerializeField] private float _tailleBalle = 1.0f;
    [SerializeField] private float _offsetX = 3.0f;
    [SerializeField] private float _offsetY = 3.0f;
    [SerializeField] private Sprite[] _sprites;
    
    

// Start is called before the first frame update
    void Start()
    {
        generateBoules();
    }
    
    private void generateBoules()
    {
        for (int i = 0; i < _longueur; i++)
        {
            for (int j = 0; j < _hauteur; j++)
            {
                GameObject boule = Instantiate(_boulePrefab, transform);
                boule.transform.position = new Vector3(transform.position.x + j * _offsetX, transform.position.y - i * _offsetY, 5);
                boule.GetComponent<SpriteRenderer>().sprite = _sprites[Random.Range(0, _sprites.Length)];
                boule.transform.localScale = new Vector3(_tailleBalle, _tailleBalle, 1.0f);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
