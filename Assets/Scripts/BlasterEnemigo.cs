using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterEnemigo : MonoBehaviour
{
    public GameObject disparoEnem;
    public Transform spawnDeDisparo;

    public float retrasoDisparo = 0.5f;
    public float cadenciaDisparo = 1.7f;

    public float velDisparo;
    public Rigidbody2D rbody;
    
    
    void Start()
    {
        Rigidbody2D rBody = GetComponent<Rigidbody2D>(); // TOMA LA NAVE
                
         // disparoEnem.transform.right = -transform.right * (velDisparo * 2); // CON ESTO INTENTABA QUE EL TIRO ENEMIGO VAYA MÁS RÁPIDO QUE LO QUE VIAJA LA NAVE ENEMIGA
        InvokeRepeating("DisparoEnemigo", retrasoDisparo, cadenciaDisparo /2); // DIVIDO POR 2 PARA QUE DISPAREN CON MAYOR FRECUENCIA
                
    }

    
    void Update()
    {
        
    }

    public void DisparoEnemigo()
    {
        GameObject clonDisparo =  Instantiate(disparoEnem, spawnDeDisparo.position, spawnDeDisparo.rotation);
        Rigidbody2D rb = clonDisparo.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.left * velDisparo, ForceMode2D.Impulse);
        Destroy(clonDisparo, 8f); // BORRA LAS NAVES ENEMIGAS AL CABO DE 8 SEGUNDOS, PERO LOS DISPAROS SIGUEN SU CURSO SIN BORRARSE (arreglar)
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
        }
    }
}
