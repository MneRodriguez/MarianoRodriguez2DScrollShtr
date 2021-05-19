using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterEnemigo : MonoBehaviour
{
    public GameObject disparoEnem;
    public Transform spawnDeDisparo;

    public float retrasoDisparo = 0.5f;
    public float cadenciaDisparo = 1.7f;

    public float velDisparo = 15f;
    public Rigidbody2D rbody;
    
    void Start()
    {
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = -transform.right * velDisparo; // EL "transform.right" LLEVA SIMBOLO NEGATIVO PARA QUE VAYA A LA IZQ, PORQUE NO HAY "transform.left"

        InvokeRepeating("DisparoEnemigo", retrasoDisparo, cadenciaDisparo /2); // DIVIDO POR 2 PARA QUE DISPAREN CON MAYOR FRECUENCIA
                
    }

    
    void Update()
    {
        Destroy(gameObject, 8f);
    }

    public void DisparoEnemigo()
    {
        Instantiate(disparoEnem, spawnDeDisparo.position, spawnDeDisparo.rotation);

    }
}
