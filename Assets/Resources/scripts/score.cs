using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public float _score = 0f;

    void Update()
    {
        scoreText.text = _score.ToString();
    }
}
