using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;  // Referência ao texto UI
    private float score;    // Tempo de sobrevivência
    private PlayerController playControllerScript;

    void Start()
    {
        playControllerScript = FindObjectOfType<PlayerController>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (playControllerScript.gameOver == false)
        {
            score += Time.deltaTime; // Soma o tempo em segundos
            scoreText.text = "Score: " + score.ToString("F2"); // Atualiza o texto
        }
    }
}