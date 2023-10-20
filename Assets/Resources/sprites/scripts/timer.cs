using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] public float _timer = 60.0f;

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        timerText.text = "Temps restant :" + _timer.ToString("0") + " secondes";
        if (_timer < 0)
        {
            SceneManager.LoadScene("Defaite");
        }
    }

}
