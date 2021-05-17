using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterEnemigo : MonoBehaviour
{
    public GameObject disparoEnem;
    public Transform spawnDeDisparo;

    public float retrasoDisparo = 0.5f;
    public float cadenciaDisparo = 1.1f;

    public float velDisparo = 100f;
    public Rigidbody rig;

    void Start()
    {
        rig.GetComponent<Rigidbody>();
        
        InvokeRepeating("DisparoEnemigo", retrasoDisparo, cadenciaDisparo);

        rig.velocity = -transform.right * velDisparo; // EL "transform.right" LLEVA SIMBOLO NEGATIVO PARA QUE VAYA A LA IZQ, PORQUE NO HAY "transform.left"
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
