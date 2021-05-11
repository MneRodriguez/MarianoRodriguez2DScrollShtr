using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJgdr : MonoBehaviour
{
    //public Sprite spriteR;

    float maxSpeed = 40f;

    public GameObject tiro;    
    public Transform zonaSpawnTiro;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(tiro, zonaSpawnTiro.position, zonaSpawnTiro.rotation);
            
        }
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;   // MOVIMIENTO DE LA NAVE

        pos.x += Input.GetAxis("Horizontal") *maxSpeed * Time.deltaTime;        
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
                
        transform.position = pos;
        

        /*float MoverHorizontal = 
        float MoverVertical = Input.GetAxis("Vertical");

        Vector2 movto = new Vector2(MoverHorizontal, MoverVertical);*/
                
    }
}
