using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        timerText.text = _timer.ToString("0");
    }
}
