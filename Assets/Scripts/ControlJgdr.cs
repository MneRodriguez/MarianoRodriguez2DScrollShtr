using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJgdr : MonoBehaviour
{
    //public Sprite spriteR;

    float maxSpeed = 40f; // se usa ?

    private GameController gameController;
    public GameObject tiro;    
    public Transform zonaSpawnTiro;
    public float velocidadTiro;


    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
        
        GameObject clonTiro =  Instantiate(tiro, zonaSpawnTiro.position, zonaSpawnTiro.rotation);
        Rigidbody2D rb = clonTiro.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.right * velocidadTiro, ForceMode2D.Impulse);
            
        }
        
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;   // MOVIMIENTO DE LA NAVE

        pos.x += Input.GetAxis("Horizontal") *maxSpeed * Time.deltaTime;        
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
                
        transform.position = pos;
                                
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("TiroEnem"))
        {
            Debug.Log("Tiro a la nave");
            Destroy(this.gameObject);
            gameController.GameOver();

            // aca tendrias que poner un cartel de perdiste, reiniciar, etc. 

        }
             
    }
 
}
