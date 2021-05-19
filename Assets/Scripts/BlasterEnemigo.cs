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
        Rigidbody2D rBody = GetComponent<Rigidbody2D>(); // TOMA LA NAVE
                
        rBody.velocity = -transform.right * velDisparo; // EL "transform.right" LLEVA SIMBOLO NEGATIVO PARA QUE LA NAVE ENEMIGA VAYA A LA IZQ, PORQUE NO HAY "transform.left"
        disparoEnem.transform.right = -transform.right * (velDisparo * 2); // CON ESTO INTENTABA QUE EL TIRO ENEMIGO VAYA MÁS RÁPIDO QUE LO QUE VIAJA LA NAVE ENEMIGA
        InvokeRepeating("DisparoEnemigo", retrasoDisparo, cadenciaDisparo /2); // DIVIDO POR 2 PARA QUE DISPAREN CON MAYOR FRECUENCIA
                
    }

    
    void Update()
    {
        
    }

    public void DisparoEnemigo()
    {
        Instantiate(disparoEnem, spawnDeDisparo.position, spawnDeDisparo.rotation);
        Destroy(gameObject, 8f); // BORRA LAS NAVES ENEMIGAS AL CABO DE 8 SEGUNDOS, PERO LOS DISPAROS SIGUEN SU CURSO SIN BORRARSE (arreglar)
        
    }
}
