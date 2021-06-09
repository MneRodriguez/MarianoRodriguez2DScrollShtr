using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject enem;
    public float velocidadNaveEnemiga;
    public Vector3 valoresSpawn;
    public int contEnem;
        
    public int score;
    public Text TextoScore;

    public Text TextoRestart;
    public bool restart;

    public Text TextoGanaste;
    public bool ganaste;

    public Text TextoGameOver;
    public bool gameOver;

    public float TiempoHastaSpawn;
    public float TiempoHastaEmpezar;


    private void Awake()
    {
        Time.timeScale = 1f;
    }

    void Start()
    {
        //enem = gameObject.GetComponent<GameObject>();
        
        restart = false;
        ganaste = false;
        gameOver = false;

        TextoRestart.gameObject.SetActive(false);
        TextoGanaste.gameObject.SetActive(false);
        TextoGameOver.gameObject.SetActive(false);

        StartCoroutine(SpawnearWaves());

        score = 0;
        ActualizarScore();

        

    }

    
    void Update()
    {
      

            if (gameOver && Input.GetKeyDown(KeyCode.R))

            {
                SceneManager.LoadScene(0);
            }
       
    }

    IEnumerator SpawnearWaves() // RUTINA QUE GENERA OLEADAS DE NAVES ENEMIGAS CADA CIERTO TIEMPO
    {
        for (int i=0; i< contEnem; i++)
        {
            yield return new WaitForSeconds(TiempoHastaEmpezar);
            Vector3 posSpawn = new Vector3(Random.Range(+valoresSpawn.x, valoresSpawn.x), Random.Range(-valoresSpawn.y, valoresSpawn.y), valoresSpawn.z);
            GameObject clonNave = Instantiate(enem, posSpawn, Quaternion.identity);
            Rigidbody2D rb = clonNave.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector3.left * velocidadNaveEnemiga, ForceMode2D.Impulse);
            
            yield return new WaitForSeconds(TiempoHastaSpawn);
        }
                
    }

    public void SumarScore (int valor)
    {
        score += valor;
        ActualizarScore();

        if (score >= 100) // mayor o igual, por sin cae justo en el 100 al sumar. 
        {
            TextoGanaste.gameObject.SetActive(true);
            ganaste = true;
            Time.timeScale = 0f;
        }

    }

    void ActualizarScore()
    {
        TextoScore.text = "Score: " + score;
    }

    public void GameOver()
    {
        TextoGameOver.gameObject.SetActive(true);
        gameOver = true;

        TextoRestart.gameObject.SetActive(true);
        restart = true;
       Time.timeScale = 0f;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
