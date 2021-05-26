using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejoDeColisiones : MonoBehaviour
{
  
    public int ValorScore;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameObject.GetComponent<GameController>();
                 
     }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TiroJgdr"))  {

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            gameController.SumarScore(ValorScore);
        }

    }
   
}
