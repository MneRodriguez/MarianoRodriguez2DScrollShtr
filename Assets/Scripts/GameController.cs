using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject enem;
    public Vector3 valoresSpawn;
    public int contEnem;
        
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

        SpawnearWaves();

        score = 0;
        ActualizarScore();

        
    }

    
    void Update()
    {
        
    }

    public void SpawnearWaves()
    {
        for (int i=0; i< contEnem; i++)
        {
            Vector3 posSpawn = new Vector3(Random.Range(-valoresSpawn.x, valoresSpawn.x), Random.Range(-valoresSpawn.y, valoresSpawn.y), valoresSpawn.z);
            Instantiate(enem, posSpawn, Quaternion.identity);
            posSpawn.x--;
        }
                
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
