﻿using System.Collections;
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
                 
        tomarJugador = gameObject.GetComponent<GameObject>(); // NO SE SI ERA "gameObject" CON MINUSCULA O CON MAYUSCULA PARA QUE TOME EL OBJ CORRESP
        tomarDisparoJgdr = gameObject.GetComponent<GameObject>();

        tomarEnemigo = gameObject.GetComponent<GameObject>();
        tomarDisparoEnem = gameObject.GetComponent<GameObject>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (tomarJugador.CompareTag("TiroEnem")) // SI AL PLAYER LO ALCANZA UN DISPARO ENEMIGO
        {
            Destroy(other.gameObject);
            gameController.GameOver();
        }

        if (tomarEnemigo.CompareTag("TiroJgdr")) // SI LOS ENEMIGOS TOCAN AL DISPARO DEL PLAYER
        {
            Destroy(other.gameObject);
            gameController.SumarScore(ValorScore);
        }
        
        Destroy(gameObject);
    }
}
