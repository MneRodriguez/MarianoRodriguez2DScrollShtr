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

    public float TiempoHastaSpawn;
    public float TiempoHastaEmpezar;

    void Start()
    {
        //enem = gameObject.GetComponent<GameObject>();
        
        restart = false;
        gameOver = false;
        TextoRestart.gameObject.SetActive(false);
        TextoGameOver.gameObject.SetActive(false);

        StartCoroutine(SpawnearWaves());

        score = 0;
        ActualizarScore();

        
    }

    
    void Update()
    {
        
    }

    IEnumerator SpawnearWaves() // RUTINA QUE GENERA OLEADAS DE NAVES ENEMIGAS CADA CIERTO TIEMPO
    {
        for (int i=0; i< contEnem; i++)
        {
            yield return new WaitForSeconds(TiempoHastaEmpezar);
            Vector3 posSpawn = new Vector3(Random.Range(+valoresSpawn.x, valoresSpawn.x), Random.Range(-valoresSpawn.y, valoresSpawn.y), valoresSpawn.z);
            Instantiate(enem, posSpawn, Quaternion.identity);
            //posSpawn.x--;
            yield return new WaitForSeconds(TiempoHastaSpawn);
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
