using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public float _score = 0f;

    private void Start()
    {
        scoreText = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = "Score :" + _score.ToString("");
    }
}
