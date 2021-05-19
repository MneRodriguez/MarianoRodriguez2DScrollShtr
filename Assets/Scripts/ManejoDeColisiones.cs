using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejoDeColisiones : MonoBehaviour
{
    public GameObject tomarJugador;
    public GameObject tomarDisparoJgdr;

    public GameObject tomarEnemigo;
    public GameObject tomarDisparoEnem;
    
    public int ValorScore;
    private GameController gameController;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameObject.GetComponent<GameController>();
                 
        tomarJugador = gameObject.GetComponent<GameObject>(); // TOMA SPRITE NAVE JUGADOR
        tomarDisparoJgdr = gameObject.GetComponent<GameObject>(); // TOMA SPRITE TIRO DEL JUGADOR

        tomarEnemigo = gameObject.GetComponent<GameObject>(); // TOMA SPRITE NAVE ENEM
        tomarDisparoEnem = gameObject.GetComponent<GameObject>(); // TOMA SPRITE TIRO ENEM
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (tomarJugador.CompareTag("TiroEnem")) // SI AL PLAYER LO ALCANZA UN DISPARO ENEMIGO
        {
            Destroy(tomarJugador.gameObject);
            gameController.GameOver();
        }

        if (tomarEnemigo.CompareTag("TiroJgdr")) // SI LOS ENEMIGOS TOCAN AL DISPARO DEL PLAYER
        {
            Destroy(tomarEnemigo.gameObject);
            gameController.SumarScore(ValorScore);
        }
        
        Destroy(gameObject);
    }
}
