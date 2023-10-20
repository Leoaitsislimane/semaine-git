using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class défaite : MonoBehaviour
{
  
    private timer timer;

    private void Start()
    {
        timer = FindObjectOfType<timer>();
    }

    private void _defaite()
    {
        SceneManager.LoadScene("Defaite", LoadSceneMode.Additive);
    }
    void Update()
    {
               
            if (timer._timer <= 0f)
            {
                _defaite();
            }
        
    }
}
