using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int score;
    public Text TextoScore;

    public Text TextoRestart;
    private bool restart;

    public Text TextoGameOver;
    private bool gameOver;

    void Start()
    {
        restart = false;
        gameOver = false;
        TextoRestart.gameObject.SetActive(false);
        TextoGameOver.gameObject.SetActive(false);
        
        score = 0;
        ActualizarScore();
    }

    
    void Update()
    {
        
    }

    public void SumarScore (int valor)
    {
        score += valor;
        ActualizarScore();
    }

    void ActualizarScore()
    {
        TextoScore.text = "Score: " + score;
    }

    public void GameOver()
    {
        TextoGameOver.gameObject.SetActive(true);
        gameOver = true;
    }
}
