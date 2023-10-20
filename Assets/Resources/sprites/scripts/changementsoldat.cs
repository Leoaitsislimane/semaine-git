using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changementsoldat : MonoBehaviour
{
    private timer _timer;
    private SpriteRenderer sprite;
    [SerializeField]private Sprite[] _sprites;
    private Transform _transform;
    private void loadSprites()
    {
        _sprites = Resources.LoadAll<Sprite>("soldat");
    }
    void Start()
    {
        loadSprites();
        sprite = GetComponent<SpriteRenderer>();
        _timer = GetComponent<timer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (_timer._timer < 40)
        {
            sprite.sprite = _sprites[2];
        }
        if (_timer._timer < 20)
        {
            sprite.sprite = _sprites[1];
        }
        if (_timer._timer < 10)
        {
            sprite.sprite = _sprites[3];
        }
        else
        {
            sprite.sprite = _sprites[0];
        }
    }
}
